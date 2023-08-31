using ComponentFactory.Krypton.Toolkit;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using ZBobb;

namespace Civ6ModdingTool
{
    



    public partial class Form1 : Form
    {
        //This method override eliminates the problem of tableLayoutPanel (and probably other controls)
        //flickering if there are some controls added to it, especially with BackgroundImage
        //Taken from this SO thread: https://stackoverflow.com/questions/75906065/tablelayoutpanel-slow-redraw
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
            CustomFont();
            AddTooltipForAllPictures();
        }

        public static class MySQLReader
        {
            public static Dictionary<string, DataTable> dataTables = new Dictionary<string, DataTable>();

            public static bool IsCharNumeric(char c)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3'
                             || c == '4' || c == '5' || c == '6'
                             || c == '7' || c == '8' || c == '9'
                             || c == '+' || c == '-')
                {
                    return true;
                }
                return false;
            }

            public static void ReadSQLFile(string file)
            {
                bool insideSingleQuotes = false;
                bool insideDoubleQuotes = false;
                bool insideNumericValue = false;
                bool insideComment = false;
                char singleQuote = '\'';
                char doubleQuote = '"';
                string command = null;


                ExpectingCommand();

                

                bool CheckIfNextCharsMatchPhrase(string phraseToCheck, string substringInclOneMoreCharThanThePhrase)
                {
                    //Checks if it's the correct command
                    for (int j = 1; j < phraseToCheck.Length; j++)
                    {
                        if (phraseToCheck.ToUpper()[j] != substringInclOneMoreCharThanThePhrase.ToUpper()[j]) { return false; }
                    }

                    //Checks if there isn't any sign like a letter or number directly after the command
                    if (substringInclOneMoreCharThanThePhrase.Last() != ' '
                        && substringInclOneMoreCharThanThePhrase.Last() != '\''
                        && substringInclOneMoreCharThanThePhrase.Last() != '"'
                        && substringInclOneMoreCharThanThePhrase.Last() != '(' //need to check here if '(' is allowed
                        && substringInclOneMoreCharThanThePhrase.Last() != ',')//need to check here if ',' is allowed
                    {
                        return false;
                    }
                    return true;
                }


                int OmitEmptyCharsOrComments(ref int index)
                {
                    for (index = index; index < file.Length; index++)
                    {
                        char c = file[index];

                        if (insideComment)
                        {
                            if (file[index] == '\n' || file[index] == '\r') { insideComment = false; }
                            continue;
                        }
                        else if (c == '-' && file[index + 1] == '-') { index++; insideComment = true; continue; }
                        else if (c == '\n' || c == '\r' || c == '\t' || c == ' ') { continue; }
                        return 1;
                    }
                    return 0; //Means the end of file
                }

                int OmitAllUntilCommaOrBrackets(ref int index)
                {
                    int insideBracketsLevel = 0;

                    for (index = index; index < file.Length; index++)
                    {
                        if (OmitEmptyCharsOrComments(ref index) == 0) { break; } //Means it is the end of file
                        char c = file[index];
                        if (c == singleQuote)
                        {
                            if (insideSingleQuotes)
                            {
                                //Line below: if there is an apostrophe inside single quotes escape it with another apostrophe
                                if (file[index + 1] == singleQuote) { index++; continue; }
                                else { insideSingleQuotes = false; continue; }
                            }
                            else { insideSingleQuotes = true; continue; }
                        }
                        if (c == doubleQuote)
                        {
                            if (insideDoubleQuotes) { insideDoubleQuotes = false; continue; }
                            else { insideDoubleQuotes = true; continue; }
                        }

                        if (c == '(' && !insideSingleQuotes && !insideDoubleQuotes) { insideBracketsLevel += 1; continue; }
                        if (c == ')' && !insideSingleQuotes && !insideDoubleQuotes)
                        {
                            if (insideBracketsLevel == 0) //Final )
                            {
                                return 1; //Found the last ')' - because no comma at the end
                            }
                            insideBracketsLevel -= 1;
                            continue;
                        }

                        if (c == ',' && insideBracketsLevel == 0 && !insideSingleQuotes && !insideDoubleQuotes)
                        {
                            return 1; //Found a ',' outside quotes
                        }
                        continue; //continue for everything else
                    }
                    return 0; //The end of file reached
                }

                string GetNextWord(ref int index, bool quotesRequired = false)
                {
                    string currentValue2 = null;
                    for (index = index; index < file.Length; index++)
                    {
                        char c = file[index];

                        if (insideComment)
                        {
                            if (c == '\n' || c == '\r') { insideComment = false; }
                            continue;
                        }
                        else if (insideSingleQuotes || insideDoubleQuotes)
                        {
                            if (insideSingleQuotes && c == singleQuote)
                            {
                                //Line below: if there is an apostrophe inside single quotes escape it with another apostrophe
                                //Then add ' to the current value and jump 2 characters ahead (index++ and then continue)
                                //E.g. if I want to write "I've" -> 'I''ve'
                                if (file[index + 1] == singleQuote) { currentValue2 += c; index++; continue; }
                                else { insideSingleQuotes = false; index++; return currentValue2 /* + c */; }
                            }

                            else if (insideDoubleQuotes && c == doubleQuote)
                            { insideDoubleQuotes = false; index++; return currentValue2 /* + c */; } //not adding c to the value

                            else if (c == '\n' || c == '\r') { continue; } //Ignore new lines
                            else if (c == '\t') { currentValue2 += ' '; continue; } //treat Tab as space
                            currentValue2 += c; continue;
                        }
                        else //if (!insideComment && !insideSingleQuotes && !insideDoubleQuotes)
                        {
                            if (c == '-' && file[index + 1] == '-') { index++; insideComment = true; continue; }

                            else if (c == singleQuote) { insideSingleQuotes = true;/* currentValue2 += c; */  continue; }
                            else if (c == doubleQuote) { insideDoubleQuotes = true;/* currentValue2 += c; */ continue; }

                            else if (c == '\n' || c == '\r' || c == '\t' || c == ' '
                                  || c == ',' || c == ')')
                            {
                                if (currentValue2 != null) { return currentValue2; }
                                continue;
                            }
                            else //Values without quotes
                            {
                                //Add numeric exception from quotesRequired
                                if (quotesRequired) { throw new Exception("Value without quotes where quotes required"); }
                                currentValue2 += c; continue;
                            }
                        }
                        return null; //This should be unreachable
                    }
                    return null; //Means it went throughout the whole file
                }


                void ExpectingCommand()
                {
                    for (int i = 0; i < file.Length; i++)
                    {
                        char e = file[i];
                        string en = file[i].ToString();

                        if (OmitEmptyCharsOrComments(ref i) == 0) { break; } //Means it is the end of file

                        e = file[i];
                        if ((file[i] == 'I' || file[i] == 'D' || file[i] == 'U' || file[i] == 'C')
                                 && !insideComment)
                        {
                            if (file[i] == 'C') { command = "CREATE TABLE IF NOT EXISTS"; }
                            else if (file[i] == 'I') { command = "INSERT INTO"; }
                            else if (file[i] == 'D') { command = "DELETE FROM"; }
                            else if (file[i] == 'U') { command = "UPDATE"; }
                            CheckIfNextCharsMatchPhrase(command, file.Substring(i, command.Length + 1));
                            i += command.Length;

                            string tableName;
                            if ((tableName = GetNextWord(ref i)) != null)
                            {
                                int iJump = -1;
                                switch (command)
                                {
                                    case "INSERT INTO":
                                        //Expecting Columns - but not necessary
                                        if (GetNextWord(ref i).ToUpper() != "VALUES") { throw new Exception("No VALUES keyword"); }
                                        //CheckIfNextCharsMatchPhrase("VALUES", file.Substring(i, "VALUES".Length + 1));
                                        //i += "VALUES".Length;

                                        iJump = ValuesInBrackets(ref i, tableName); break;

                                    case "DELETE FROM":
                                        iJump = ValuesInBrackets(ref i, tableName); break; //REMOVE
                                                                                           //Expecting WHERE 
                                    case "UPDATE":
                                        //Expecting SET
                                        //Expecting WHERE
                                        iJump = ValuesInBrackets(ref i, tableName); break; //REMOVE
                                    case "CREATE TABLE IF NOT EXISTS":
                                        iJump = ValuesInBrackets(ref i, tableName, isCreateTable: true); break;
                                }
                                if (iJump == -1) { throw new Exception("Sth wrong with commands "); return; }
                            }
                            command = null;
                            continue;
                        }
                        else
                        {
                            throw new Exception("Syntax Error: file doesn't start with a command "); return;
                        }
                    }
                }

                int ValuesInBrackets(ref int index, string __tableName, bool isCreateTable = false)
                {
                    string[] columns = new string[0];

                    for (index = index; index < file.Length; index++)
                    {
                        OmitEmptyCharsOrComments(ref index);

                        char c = file[index];

                        if (c != '(')
                        {
                            throw new Exception("Syntax Error: no ( where it should be starting brackets" +
                                " (char: " + c + " at pos: " + index + " ).");
                        }
                        else
                        {
                            index++;
                            while (true)
                            {
                                string outcome = GetNextWord(ref index);
                                if (isCreateTable && (outcome.ToUpper() == "PRIMARY" || outcome.ToUpper() == "FOREIGN"))
                                {
                                    if (OmitAllUntilCommaOrBrackets(ref index) == 0) { break; } //If keyword then omit everything
                                }
                                else
                                {
                                    columns = columns.Append(outcome).ToArray(); //If normal entry then add it...
                                    if (OmitAllUntilCommaOrBrackets(ref index) == 0) { break; }  //...and then omit everything (for now)
                                    //OmitEmptyCharsOrComments(ref index);
                                }
                                c = file[index];
                                if (c == ',') { index++; continue; }
                                else if (c == ')') { index++; break; }
                            }
                            if (OmitEmptyCharsOrComments(ref index) == 0) { break; }
                            c = file[index];
                            if (c == ';')
                            {
                                if (isCreateTable)
                                {
                                    DataTable dt = new DataTable();
                                    for (int l = 0; l < columns.Length; l++)
                                    {
                                        dt.Columns.Add(columns[l]);
                                    }
                                    dt.TableName = __tableName;
                                    dataTables.Add(__tableName, dt);
                                }
                                else //means it's values to insert into a table
                                {
                                    DataTable dt = dataTables[__tableName];

                                    //Either this OR...
                                    dt.Rows.Add(columns);

                                    //...OR the code below - iteration allows to later set a column order, etc.
                                    //int currentRowIndex = dt.Rows.Count;
                                    //dt.Rows.Add();
                                    //for (int l = 0; l < columns.Length; l++)
                                    //{
                                    //    dt.Rows[currentRowIndex][l] = columns[l];
                                    //}

                                }
                                return 1;
                            }
                            else
                            {
                                throw new Exception("Syntax Error: no ; after values ");
                            }
                        }
                    }
                    return 0; //Means it reached the end of file
                }
            }


            public static void ReadSQLFile_OLD(string file)
            {
                bool insideSingleQuotes = false;
                bool insideDoubleQuotes = false;
                bool insideNumericValue = false;
                bool insideComment = false;
                bool sendValue = false;
                bool insideValue = false;
                char singleQuote = '\'';
                char doubleQuote = '"';
                string command = null;
                string currentValue = null;


                ExpectingCommand();

                bool IsCharNumeric(char c)
                {
                    if (c == '0' || c == '1' || c == '2' || c == '3'
                                 || c == '4' || c == '5' || c == '6'
                                 || c == '7' || c == '8' || c == '9'
                                 || c == '+' || c == '-')
                    {
                        return true;
                    }
                    return false;
                }

                bool CheckIfNextCharsMatchPhrase(string phraseToCheck, string substringInclOneMoreCharThanThePhrase)
                {
                    //Checks if it's the correct command
                    for (int j = 1; j < phraseToCheck.Length; j++)
                    {
                        if (phraseToCheck.ToUpper()[j] != substringInclOneMoreCharThanThePhrase.ToUpper()[j]) { return false; }
                    }

                    //Checks if there isn't any sign like a letter or number directly after the command
                    if (substringInclOneMoreCharThanThePhrase.Last() != ' '
                        && substringInclOneMoreCharThanThePhrase.Last() != '\''
                        && substringInclOneMoreCharThanThePhrase.Last() != '"'
                        && substringInclOneMoreCharThanThePhrase.Last() != '(' //need to check here if '(' is allowed
                        && substringInclOneMoreCharThanThePhrase.Last() != ',')//need to check here if ',' is allowed
                    {
                        return false;
                    }
                    return true;
                }

                void ExpectingCommand()
                {
                    for (int i = 0; i < file.Length; i++)
                    {
                        char e = file[i];
                        string en = file[i].ToString();

                        if (insideComment)
                        {
                            if (file[i] == '\n' || file[i] == '\r') { insideComment = false; }
                            continue;
                        }
                        else if (file[i] == '-' && !insideComment)
                        {
                            if (file[i + 1] == '-') { insideComment = true; continue; }
                            else { throw new Exception("Syntax Error: - in AddEntriesFinal"); return; }
                        }
                        else if (file[i] == '\n' || file[i] == '\r' || file[i] == ' ' || file[i] == '\t')
                        {
                            continue;
                        }


                        if ((file[i] == 'I' || file[i] == 'D' || file[i] == 'U' || file[i] == 'C')
                                 && !insideComment)
                        {
                            if (file[i] == 'C') { command = "CREATE TABLE IF NOT EXISTS"; }
                            else if (file[i] == 'I') { command = "INSERT INTO"; }
                            else if (file[i] == 'D') { command = "DELETE FROM"; }
                            else if (file[i] == 'U') { command = "UPDATE"; }
                            CheckIfNextCharsMatchPhrase(command, file.Substring(i, command.Length + 1));
                            i += command.Length;

                            string tableName;
                            if ((tableName = ExpectingValue(ref i)) != null)
                            {
                                int iJump = -1;
                                switch (command)
                                {
                                    case "INSERT INTO":
                                        //Expecting Columns - but not necessary

                                        CheckIfNextCharsMatchPhrase("VALUES", file.Substring(i, "VALUES".Length + 1));
                                        i += "VALUES".Length;

                                        iJump = ExpectingBrackets(ref i, tableName); break;

                                    case "DELETE FROM":
                                        iJump = ExpectingBrackets(ref i, tableName); break; //REMOVE
                                                                                            //Expecting WHERE 
                                    case "UPDATE":
                                        //Expecting SET
                                        //Expecting WHERE
                                        iJump = ExpectingBrackets(ref i, tableName); break; //REMOVE
                                    case "CREATE TABLE IF NOT EXISTS":
                                        iJump = ExpectingBrackets(ref i, tableName, isCreateTable: true); break;
                                }
                                if (iJump == -1) { throw new Exception("Sth wrong with commands "); return; }
                            }
                            command = null;
                            continue;
                        }
                        else
                        {
                            throw new Exception("Syntax Error: any other thing "); return;
                        }
                    }
                }

                /// <summary>
                /// This method checks if the character at the given index is Single Quotes ('\'') or Double Quotes ('"')
                /// or if it starts a comment "--" or if it's an empty space ' ' or tab '\t' or new line '\r' or '\n'.
                /// It also sets the vars insideSingle/DoubleQuotes and insideComment respectively.
                /// It continues in a loop until it finds a char that isn't one of the above - then it returns 0.
                /// </summary>
                int CharCheckIfQuotesCommentEmpty(ref int index, ref string _currentValue)
                {
                    if (index == 200887) { MessageBox.Show(""); }
                    for (index = index; index < file.Length; index++)
                    {
                        char c = file[index];

                        if (insideComment)
                        {
                            if (c == '\n' || c == '\r') { insideComment = false; }
                            continue;
                        }
                        else //if (!insideComment)
                        {
                            if (insideSingleQuotes)
                            {
                                //if inside quotes accept anything as a next sign in the current value
                                //except closing quote sign

                                //should possibly be return; continue means it will ignore every empty space,
                                //but return means there could be a problem with ','
                                //later - it may try to find another value even though there is no ',' in between
                                if (c == singleQuote) { insideSingleQuotes = false; insideValue = false; sendValue = true; continue; }
                                else if (c == '\n' || c == '\r') { continue; } //Ignore new lines
                                else if (c == '\t') { currentValue += ' '; continue; } //treat Tab as space
                                currentValue += c; continue;
                            }
                            else if (insideDoubleQuotes)
                            {
                                if (c == doubleQuote) { insideDoubleQuotes = false; insideValue = false; sendValue = true; continue; }
                                else if (c == '\n' || c == '\r') { continue; } //Ignore new lines
                                else if (c == '\t') { currentValue += ' '; continue; } //treat Tab as space
                                currentValue += c; continue;
                            }
                            else //if (!insideSingleQuotes && !insideDoubleQuotes)
                            {
                                if (c == '-') //&& !insideSingleQuotes && !insideDoubleQuotes && !insideComment)
                                {
                                    if (file[index + 1] == '-') { insideComment = true; continue; }
                                    else if (IsCharNumeric(file[index + 1]))
                                    {
                                        currentValue += file[index]; continue;
                                    }
                                    else { throw new Exception("Syntax Error: - "); return -1; }
                                    //Line above - does not iclude numeric values
                                }
                                else if (c == singleQuote) { insideSingleQuotes = true; insideValue = true; continue; }
                                else if (c == doubleQuote) { insideDoubleQuotes = true; insideValue = true; continue; }

                                else if (c == '\n' || c == '\r' || c == '\t' || c == ' ')
                                {
                                    if (currentValue != null) { sendValue = true; insideValue = false; }
                                    continue;
                                }
                            }
                        }
                        return 0;
                    }
                    return 0;
                }

                int CharIgnoreUntilCommaOrBrackets(ref int index)
                {
                    int insideBracketsLevel = 0;

                    for (index = index; index < file.Length; index++)
                    {

                        if (CharCheckIfQuotesCommentEmpty(ref index, ref currentValue) == -1) { return -1; }

                        if (index == 200610) { MessageBox.Show(""); }
                        char c = file[index];
                        if (c == '(') { insideBracketsLevel += 1; continue; }
                        if (c == ')')
                        {
                            if (insideBracketsLevel == 0) //Final )
                            {
                                return 1; //Found the last ')' - because no comma at the end
                            }
                            insideBracketsLevel -= 1;
                            continue;
                        }

                        if (!insideSingleQuotes && !insideDoubleQuotes && insideBracketsLevel == 0 && c == ',')
                        {
                            return 1; //Found a ',' outside quotes
                        }
                        continue; //continue for everything else
                    }
                    return 0; //The end of file reached
                }


                int CharCheckIfStartsKeyword(ref int index)
                {
                    string[] columns = new string[0];
                    for (index = index; index < file.Length; index++)
                    {
                        if (index == 200887) { MessageBox.Show(""); }
                        char c = file[index];

                        if ((c == 'T' || c == 't' || c == 'L' || c == 'l' || c == 'I' || c == 'i' || c == 'B' || c == 'b'
                          || c == 'R' || c == 'r' || c == 'F' || c == 'f' || c == 'P' || c == 'p')
                                 && !insideComment)
                        {
                            if (c == 'T' || c == 't') { command = "TEXT"; }
                            else if (c == 'L' || c == 'l') { command = "LocalizedText"; }
                            else if (c == 'I' || c == 'i') { command = "INTEGER"; }
                            else if (c == 'B' || c == 'b') { command = "BOOLEAN"; }
                            else if (c == 'R' || c == 'r') { command = "REAL"; }
                            else if ((c == 'F' || c == 'f') && (file[index + 1] == 'L' || file[index + 1] == 'l'))
                            { command = "FLOAT"; }
                            else if ((c == 'F' || c == 'f') && (file[index + 1] == 'O' || file[index + 1] == 'o'))
                            { command = "FOREIGN KEY"; }
                            else if (c == 'P' || c == 'p') { command = "PRIMARY KEY"; }
                            if (CheckIfNextCharsMatchPhrase(command, file.Substring(index, command.Length + 1)) == false)
                            {
                                throw new Exception("KUrwa Błąd");
                            }

                            index += command.Length;

                            if (CharIgnoreUntilCommaOrBrackets(ref index) == 1) { command = null; return 1; }
                        }
                        return 0; //This will return after each iteration - so in fact iteration is useless
                    }
                    return 0;
                }


                string ExpectingValue(ref int index, bool isNoQuotesAllowed = false, bool isNumericAllowed = true, bool isNullAllowed = false)
                {
                    //currentValue = null;
                    for (index = index; index < file.Length; index++)
                    {
                        if (index == 200265) { MessageBox.Show(""); }

                        if (CharCheckIfQuotesCommentEmpty(ref index, ref currentValue) == -1) { return null; }

                        CharCheckIfStartsKeyword(ref index);

                        //if we know from another method that value should already be sent, send it
                        if (sendValue) { sendValue = false; return currentValue; }



                        char c = file[index];
                        if (IsCharNumeric(c) && !insideValue && !isNumericAllowed) { throw new Exception("Syntax Error: values outside of quotes cannot start with numeric value "); }

                        //check for this in another method - index need to be -1 so that the other method can encounter it
                        if (c == ',') { return currentValue; }

                        else if (c == ')') { return currentValue; }

                        else { currentValue += c; continue; }
                    }
                    return null;
                }


                int ExpectingBrackets(ref int index, string __tableName, bool isOptional = false, bool isCreateTable = false)
                {
                    bool openBrackets = false;
                    bool closeBrackets = false;

                    string[] columns = new string[0];

                    currentValue = null;

                    for (index = index; index < file.Length; index++)
                    {
                        if (index == 200887) { MessageBox.Show(""); }
                        if (CharCheckIfQuotesCommentEmpty(ref index, ref currentValue) == -1) { return -1; }

                        if (insideSingleQuotes || insideDoubleQuotes) { throw new Exception("Syntax Error: quotes before () "); }

                        char c = file[index];
                        if (!openBrackets) //if not yet (openBrackets)
                        {
                            if (c == '(') { openBrackets = true; continue; }
                            else { throw new Exception("Syntax Error: ( "); return -1; }
                        }
                        else //if (openBrackets)
                        {
                            if (!closeBrackets) //if (openBrackets) but not yet (closedBrackets)
                            {
                                string outcome = "";
                                while (outcome != null)
                                {
                                    outcome = ExpectingValue(ref index);
                                    if (file[index] == ',')
                                    {
                                        index++; //need to increment index here, because continue below does not do that
                                        // adds another value (column name) as the next item in columns array
                                        columns = columns.Append(currentValue).ToArray();
                                        //next column
                                        //currentColumn += 1;
                                        currentValue = null;
                                        continue;
                                    }
                                    else if (file[index] == ')')
                                    {
                                        //index++;
                                        closeBrackets = true;
                                        // adds another value (column name) as the next item in columns array
                                        columns = columns.Append(currentValue).ToArray();
                                        //reset columns - not necessary
                                        //currentColumn = 0;
                                        currentValue = null;
                                        break;
                                    }
                                }


                            }
                            else
                            {
                                if (CharCheckIfQuotesCommentEmpty(ref index, ref currentValue) == -1) { return -1; }
                                c = file[index];
                                if (c == ';')
                                {
                                    if (isCreateTable)
                                    {
                                        DataTable dt = new DataTable();
                                        for (int l = 0; l < columns.Length; l++)
                                        {
                                            dt.Columns.Add(columns[l]);
                                        }
                                        dt.TableName = __tableName;
                                        dataTables.Add(__tableName, dt);
                                    }
                                    else //means it's values to insert into a table
                                    {
                                        DataTable dt = dataTables[__tableName];

                                        //Either this OR...
                                        dt.Rows.Add(columns);

                                        //...OR the code below - iteration allows to later set a column order, etc.
                                        //int currentRowIndex = dt.Rows.Count;
                                        //dt.Rows.Add();
                                        //for (int l = 0; l < columns.Length; l++)
                                        //{
                                        //    dt.Rows[currentRowIndex][l] = columns[l];
                                        //}

                                    }
                                    return index + 1;
                                }
                                else //means it's a columns order to insert values - it should return this value
                                {
                                    throw new Exception("Syntax Error: no ; after values ");
                                }

                                ////Check for keywords here - OR it can be done later once the columns are already added
                                //if (c == '(') { throw new Exception("Syntax Error: ( again inside brackets "); return -1; }
                                //else if (c == ';') { throw new Exception("Syntax Error: ; inside brackets "); return -1; }

                                //else { currentValue += c; continue; } //all other characters are accepted
                            }
                        }
                    }
                    return 1;
                }
            }

        }


        private void AllGridviews_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string tableName = gridview.Name.Replace("GridView_", "");
            DataTable dt = dataTables[tableName];
            if (dt == null) { throw new Exception("The table: '" + tableName + "' not found in dataTables"); }

            string gridviewCellText = gridview[e.ColumnIndex, e.RowIndex].Value?.ToString();
            string gridviewColumnHeaderText = gridview.Columns[e.ColumnIndex].HeaderText;

            //dt.Rows[e.RowIndex][gridviewColumnHeaderText] = gridviewCellText;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == gridview[0, e.RowIndex].Value?.ToString())
                {
                    row[gridviewColumnHeaderText] = gridviewCellText;
                }
            }

        }

        /// <summary>
        /// This should be used to allow updating the corresponding DataTable in dataTables dictionary
        /// when any Control in Panel_Table_(...) is changed by the user <para></para>
        /// Events to subscribe to in different Control Types: <para></para>
        /// TextBoxes -> TextChanged Event <para></para>
        /// ComboBoxes -> TextChanged Event <para></para>
        /// CheckBoxes -> CheckedChanged <para></para>
        /// </summary>
        private void AllPanelTableControls_ControlValueChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            Control groupBox; 
            string tableName;
            string currentObject;
            if ((groupBox = ctrl.Parent).GetType() == typeof(GroupBox)) //If control is in a groupbox, get the groupbox' parent's name
            {
                tableName = groupBox.Parent.Name.Replace("Panel_Table_", "");
                currentObject = groupBox.Parent.Tag?.ToString();    //This is currently chosen Unit / Ability / Modifier / etc.
            }
            else
            {
                tableName = ctrl.Parent.Name.Replace("Panel_Table_", "");
                currentObject = ctrl.Parent.Tag?.ToString();
            }
            
            //if (tableName == "Units") { currentObject = CurrentUnit_Label.Text; }
            //else if (tableName == "Modifiers") { currentObject = CurrentModifier_Label.Text; }
            //else if (tableName == "Requirements") { currentObject = CurrentRequirement_Label.Text; }
            //else if (tableName == "UnitAbilities") { currentObject = GridView_UnitAbilities.CurrentRow?.Cells[0].Value?.ToString(); }
            if (String.IsNullOrEmpty(currentObject)) { return; }

            DataTable dt;
            if (ctrl.Name.Contains("_XP1_"))        { dt = dataTables[tableName + "_XP1"]; }
            else if (ctrl.Name.Contains("_XP2_"))   { dt = dataTables[tableName + "_XP2"]; }
            else                                    { dt = dataTables[tableName]; }
            if (dt == null) { throw new Exception("The table: '" + tableName + "' not found in dataTables"); }

            string newValue;
            if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox) ||
                ctrl.GetType() == typeof(ZBobb.AlphaBlendTextBox) ||
                ctrl.GetType() == typeof(ComboBox) || ctrl.GetType() == typeof(KryptonComboBox))
            { newValue = ctrl.Text; }
            else if (ctrl.GetType() == typeof(CheckBox)) 
            {
                if (((CheckBox)ctrl).Checked) { newValue = "1"; }
                else { newValue = "0"; }
            }
            else { throw new Exception("Updating value in: " + ctrl.GetType() + " Control is not implemented"); }

            string columnName = ctrl.Name.Split('_').Last();
            bool entryFound = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == currentObject)
                {
                    if (ctrl.Name.StartsWith("tbx_Loc")) //If control's content is from LocalizedText table
                    {
                        ChangeLocalizedText(row[columnName].ToString(), newValue);
                        return;
                    }
                    entryFound = true;
                    row[columnName] = newValue;
                    break;
                }
            }
            if (!entryFound) //Means it is any of the Expansion 1 or 2 tables and there are no entries for currentObject
            {                   //If it's a table from the base game the entry should be found
                                //(otherwise it wouldn't even display in the program in the first place)
                DataRow newRow = dt.NewRow();   //So we need to add the currentObject entry and then newValue
                newRow[0] = currentObject;
                newRow[columnName] = newValue;
                dt.Rows.Add(newRow);
            }
        }

        private void SubscribeToEditCellForAllTables()
        {
            foreach (string table in dataTables.Keys)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    DataGridView gridView = tab.Controls["Gridview_" + table] as DataGridView;
                    if (gridView == null) { continue; }

                    gridView.CellEndEdit += AllGridviews_CellEndEdit;
                    break;
                }
            }
        }

        private void SubscribeToEditControlForAllTablePanels()
        {
            Panel[] panels = new Panel[] { Panel_Table_Units, Panel_Table_Modifiers, Panel_Table_Requirements,
                                           Panel_Table_UnitAbilities };

            foreach (Panel panel in panels)
            {
                SubscribeToEditControlForEachControlInContainer(panel);
            }

            void SubscribeToEditControlForEachControlInContainer(Control container)
            {
                foreach (Control ctrl in container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox) || 
                        ctrl.GetType() == typeof(ZBobb.AlphaBlendTextBox) ||
                        ctrl.GetType() == typeof(ComboBox) || ctrl.GetType() == typeof(KryptonComboBox)) 
                    { ctrl.TextChanged += AllPanelTableControls_ControlValueChanged; }
                    else if (ctrl.GetType() == typeof(CheckBox))
                    { ((CheckBox)ctrl).CheckedChanged += AllPanelTableControls_ControlValueChanged; }
                    else if (ctrl.GetType() == typeof(GroupBox))
                    { SubscribeToEditControlForEachControlInContainer(ctrl); }
                }
            }
        }

        private void AddTooltipForAllPictures()
        {
            Panel[] panels = new Panel[] { Panel_Table_Units, Panel_Table_Modifiers, Panel_Table_Requirements };

            foreach (Panel panel in panels)
            {
                AddTooltipForEachPictureInContainer(panel);
            }

            void AddTooltipForEachPictureInContainer(Control container)
            {
                foreach (Control ctrl in container.Controls)
                {
                    if (ctrl.GetType() != typeof(PictureBox) && ctrl.GetType() != typeof(GroupBox)) { continue; }
                    if (ctrl.GetType() == typeof(GroupBox))
                    { AddTooltipForEachPictureInContainer(ctrl); }
                    else
                    {
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(ctrl, ctrl.Name.Replace("pic_", ""));
                    }
                }
            }
        }

        private void AddEntriesToDataTables()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(openFileDialog.FileName);
                MySQLReader.ReadSQLFile(file);
                dataTables = MySQLReader.dataTables;
            }
        }

        private void PrintEntriesToPanel(string entryID, Panel panel)
        {
            string locName = "Name not found";
            string locDesc = "Description not found";

            PrintEntriesToControls(entryID, panel);
            PrintLocalizedTextToControls(entryID);

            void PrintEntriesToControls(string _entryID, Control container)
            {
                foreach (Control ctrl in container.Controls)
                {
                    //if (dataTables.ContainsKey("LocalizedText") && _entryID != null && ctrl.Name.StartsWith("tbx_Loc")) { continue; }
                    if (ctrl.GetType() == typeof(Label)) { continue; }
                    if (_entryID == null)
                    {
                        if (ctrl.GetType() == typeof(CheckBox)) { ((CheckBox)ctrl).Checked = false; }
                        else { ctrl.Text = null; }
                        continue;
                    }
                    if (ctrl.GetType() == typeof(GroupBox)) 
                    { 
                        PrintEntriesToControls(_entryID, ctrl); 
                        continue; 
                    }

                    DataTable dt;
                    string tableName = panel.Name.Replace("Panel_Table_", ""); //Important: panel.Name NOT container.Name
                                                                               //(if GroupBox the name is still of the parent panel)
                    if (ctrl.Name.Contains("_XP1_"))        { dt = dataTables[tableName + "_XP1"]; }
                    else if (ctrl.Name.Contains("_XP2_"))   { dt = dataTables[tableName + "_XP2"]; } 
                    else                                    { dt = dataTables[tableName]; } 
                                                                                      
                    string colName = ctrl.Name.Split('_').Last();
                    bool isEntryIDfoundInRows = false;
                    if (dt.Columns.Contains(colName))
                    {
                        DataColumn col = dt.Columns[colName];
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row[0].ToString() == _entryID)
                            {
                                if (dataTables.ContainsKey("LocalizedText") && ctrl.Name.StartsWith("tbx_Loc")) 
                                {
                                    locName = row["Name"].ToString();
                                    locDesc = row["Description"].ToString();
                                    isEntryIDfoundInRows = true;
                                    break;
                                }
                                if (ctrl.GetType() == typeof(CheckBox))
                                {
                                    if (row[col].ToString() == "1") { ((CheckBox)ctrl).Checked = true; }
                                    else                            { ((CheckBox)ctrl).Checked = false; }
                                }
                                else
                                {
                                    ctrl.Text = row[col].ToString();
                                }
                                isEntryIDfoundInRows = true;
                                break;
                            }
                        }
                    }
                    if (!isEntryIDfoundInRows)      //Clear controls if no entry found
                    {
                        if (ctrl.GetType() == typeof(CheckBox)) { ((CheckBox)ctrl).Checked = false; }
                        else { ctrl.Text = null; }
                    }
                }
            }

            void PrintLocalizedTextToControls(string _entryID)
            {
                //Units/UnitAbilities Panel - Localized Texts (Name, Description)
                if (!dataTables.ContainsKey("LocalizedText")) { return; }
                if (_entryID == null) { return; }
                if (!_entryID.Contains("UNIT") && !_entryID.Contains("ABILITY")) { return; }

                bool locNameFound = false;
                bool locDescFound = false;
                //string locName = "LOC_" + _entryID.Replace("'", "") + "_NAME";
                //string locDesc = "LOC_" + _entryID.Replace("'", "") + "_DESCRIPTION";
                Control nameTbx = null;
                Control descTbx = null;
                if (panel == Panel_Table_Units) { nameTbx = tbx_Loc_Unit_Name; descTbx = tbx_Loc_Unit_Description; }
                else if (panel == Panel_Table_UnitAbilities) { nameTbx = tbx_Loc_Abilitie_Name; descTbx = tbx_Loc_Abilitie_Description; }
                foreach (DataRow row in dataTables["LocalizedText"].Rows)
                {
                    if (row[1].ToString() == locName)
                    {
                        nameTbx.Text = row[2].ToString();
                        locNameFound = true;
                    }
                    else if (row[1].ToString() == locDesc)
                    {
                        descTbx.Text = row[2].ToString();
                        locDescFound = true;
                    }
                    if (locNameFound && locDescFound) { break; }
                }
                if (!locNameFound) { nameTbx.Text = locName; } //"No matching name found in LocalizedText"
                if (!locDescFound) { descTbx.Text = locDesc; } //"No matching description found in LocalizedText"
            }
            
        }
        
        
        private void PrintRequirementSets(string modifierID)
        {
            DataTable tableModifiers = dataTables["Modifiers"];
            DataTable tableRequirementSets = dataTables["RequirementSets"];
            foreach (DataRow rowMod in tableModifiers.Rows)
            {
                if (rowMod["ModifierId"].ToString() == modifierID)
                {
                    GridView_RequirementSets.Rows.Clear();
                    string ownerReqSetId;
                    string subjectReqSetId;
                    if ((ownerReqSetId = rowMod["OwnerRequirementSetId"].ToString()) != "NULL")
                    {
                        foreach (DataRow row in tableRequirementSets.Rows)
                        {
                            if (row["RequirementSetId"].ToString() == ownerReqSetId)
                            {
                                GridView_RequirementSets.Rows.Add(row.ItemArray);
                            }
                        }
                    }
                    if ((subjectReqSetId = rowMod["SubjectRequirementSetId"].ToString()) != "NULL")
                    {
                        foreach (DataRow row in tableRequirementSets.Rows)
                        {
                            if (row["RequirementSetId"].ToString() == subjectReqSetId)
                            {
                                GridView_RequirementSets.Rows.Add(row.ItemArray);
                            }
                        }
                    }
                    break;
                }
            }
        }

        private void PrintEntriesToGridviewNEW(int entryColumn = 0, DataGridView[] gridViews = null, string entryID = null)
        {
            foreach (DataGridView gridView in gridViews)
            {
                if (gridView.Columns.Count == 0) { continue; }

                DataTable table;
                if (gridView == GridView_UnitTags || gridView == GridView_AbilityTags) { table = dataTables["TypeTags"]; }
                else { table = dataTables[gridView.Name.Replace("GridView_", "")]; }
                
                gridView.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    if (row[entryColumn].ToString() == entryID)
                    {
                        int gridRowIndex = gridView.Rows.Add("");
                        for (int i = 0; i < gridView.ColumnCount; i++)
                        {
                            gridView[i, gridRowIndex].Value = row[gridView.Columns[i].HeaderText].ToString();
                        }
                        gridView.CurrentCell = null;
                        gridView.CurrentCell = gridView[0, 0];
                    }
                }
            }
        }

        List<KryptonButton> unitAbilitiesButtons = new List<KryptonButton>();
        private void PrintEntriesToGridviewUnitAbilities()
        {
            //Finding abilities that correspond to unit Class Tags, but only those that have Inactive = 0
            //(these are inherent unit abilities right from the beginning, not given by e.g. traits, buildings, religion, etc.)
            DataGridView gridView = GridView_UnitAbilities;
            DataTable table = dataTables["TypeTags"];
            GridView_UnitAbilities.Rows.Clear();
            GridView_AbilityTags.Rows.Clear();
            dataTables["UnitAbilities"].PrimaryKey = new DataColumn[] { dataTables["UnitAbilities"].Columns[0] };

            foreach (KryptonButton btn in unitAbilitiesButtons)
            {
                btn.Dispose();
            }
            unitAbilitiesButtons.Clear();

            foreach (DataGridViewRow gridRow_UnitTag in GridView_UnitTags.Rows)
            {
                string unitTag = gridRow_UnitTag.Cells[0].Value?.ToString();
                foreach (DataRow row in table.Rows)
                {
                    if (row[1].ToString() == unitTag && row[0].ToString().Contains("ABILITY_"))
                    {
                        DataRow unitAbilitiesRow = dataTables["UnitAbilities"].Rows.Find(row[0].ToString());
                        if (unitAbilitiesRow != null && unitAbilitiesRow["Inactive"]?.ToString() == "0")
                        {
                            int gridRowIndex = gridView.Rows.Add("");
                            for (int i = 0; i < gridView.ColumnCount; i++)
                            {
                                gridView[i, gridRowIndex].Value = unitAbilitiesRow[gridView.Columns[i].HeaderText].ToString();
                            }
                            gridView.CurrentCell = null;
                            gridView.CurrentCell = gridView[0, 0];
                            
                            if (chbx_ShowAbilitiesTags.Checked) { CreateUnitAbilityButton(unitTag); }
                            
                        }
                    }
                }
            }

            void CreateUnitAbilityButton(string buttonText)
            {
                KryptonButton btn = new KryptonButton();
                int btnHeight = gridView.RowTemplate.Height;
                unitAbilitiesButtons.Add(btn);
                btn.Size = new Size(150, btnHeight);
                btn.Location = new Point(gridView.Left - btn.Width,
                                        gridView.Top + btn.Height * unitAbilitiesButtons.Count);
                btn.Text = buttonText;
                btn.StateCommon.Content.ShortText.Font = new Font(myFonts.Families[3], 9);
                btn.StateCommon.Content.ShortText.Color1 = Color.White;
                btn.StateCommon.Back.Color1 = Color.DimGray;
                btn.StateCommon.Back.Color2 = Color.Brown;
                btn.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
                btn.StateCommon.Border.Draw = InheritBool.False;
                btn.Enabled = false;
                gridView.Parent.Controls.Add(btn);
                btn.BringToFront();
            }
        }

        private void ResetAllTables()
        {
            foreach (var table in dataTables)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    DataGridView gridView = tab.Controls["GridView_" + table.Key] as DataGridView;
                    if (gridView == null) { continue; }
                    if (gridView.Columns.Count == 0) { continue; }


                    if (gridView == GridView_Modifiers || gridView == GridView_RequirementSetRequirements) { continue; }

                    gridView.Rows.Clear();

                    foreach (DataRow row in table.Value.Rows)
                    {
                        int gridRowIndex = gridView.Rows.Add(""); //For a strange reason there is an error when adding an empty row, so I needed to add ""
                        for (int i = 0; i < gridView.ColumnCount; i++)
                        {
                            gridView[i, gridRowIndex].Value = row[gridView.Columns[i].HeaderText].ToString();
                        }
                    }
                    //gridView.CurrentCell = null;
                    gridView.ClearSelection();
                }
            }
        }


        private void PrintEntriesToGridview(bool clearRows = false, string entryID = null)
        {
            foreach (var table in dataTables)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    DataGridView gridView = tab.Controls["GridView_" + table.Key] as DataGridView;
                    if (gridView == null) { continue; }
                    if (gridView.Columns.Count == 0) { continue; }

                    if (clearRows == true) { gridView.Rows.Clear(); }

                    if (gridView == GridView_RequirementSets) { continue; }


                    //ORIGINAL WORKING
                    if (gridView == GridView_Units || gridView == GridView_Modifiers 
                        || gridView == GridView_UnitPromotionClasses)
                    {
                        if (entryID != null) { continue; }

                        foreach (DataRow row in table.Value.Rows)
                        {
                            int gridRowIndex = gridView.Rows.Add(""); //For a strange reason there is an error when adding an empty row, so I needed to add ""
                            for (int i = 0; i < gridView.ColumnCount; i++)
                            {
                                gridView[i, gridRowIndex].Value = row[gridView.Columns[i].HeaderText].ToString();
                            }
                        }
                        //gridView.CurrentCell = null;
                        gridView.ClearSelection();
                    }
                    else
                    {
                        gridView.Rows.Clear();
                        foreach (DataRow row in table.Value.Rows)
                        {
                            if (row[0].ToString() == entryID)
                            {
                                int gridRowIndex = gridView.Rows.Add();
                                for (int i = 0; i < gridView.ColumnCount; i++)
                                {
                                    gridView[i, gridRowIndex].Value = row[gridView.Columns[i].HeaderText].ToString();
                                }
                            }

                        }
                        //gridView.CurrentCell = null;
                        gridView.ClearSelection();
                    }
                }
            }
        }

        
        
        
        
        Dictionary<string, DataTable> dataTables = new Dictionary<string, DataTable>();
        private void CreateDataTablesFromSQLFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    bool isLineInsideTable = false;
                    string tableName = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string createTableCommand = "CREATE TABLE IF NOT EXISTS";
                        int firstQuotesIndex = line.IndexOf('"');
                        int secondQuotesIndex = line.IndexOf('"', firstQuotesIndex + 1);
                        string columnName = null;



                        if (line.Contains(createTableCommand))
                        {
                            tableName = line.Substring(firstQuotesIndex + 1, secondQuotesIndex - (firstQuotesIndex + 1));
                            dataTables.Add(tableName, new DataTable());

                            isLineInsideTable = true;

                        }
                        else if (isLineInsideTable && tableName != null)
                        {
                            if (line.Contains("FOREIGN KEY"))
                            {
                                //TO DO
                            }
                            else if (line.Contains("PRIMARY KEY"))
                            {
                                //TO DO
                            }
                            else
                            {
                                if ((secondQuotesIndex - (firstQuotesIndex + 1)) > 0)
                                {
                                    columnName = line.Substring(firstQuotesIndex + 1, secondQuotesIndex - (firstQuotesIndex + 1));

                                }
                                if (!String.IsNullOrEmpty(columnName))
                                {
                                    dataTables[tableName].Columns.Add(columnName);
                                }
                            }
                        }

                        if (line.Contains(");"))
                        {
                            isLineInsideTable = false;
                        }

                        //List<string> textBoxText = new List<string>();
                        //foreach (var keyValuePair in dataTables)
                        //{
                        //    textBoxText.Add(keyValuePair.Key + "::" + String.Join(";", keyValuePair.Value.Columns));
                        //}
                        //richTextBox1.Text = String.Join(Environment.NewLine, textBoxText);
                    }
                }
                
            }
        }
        
        private void PrintDataTablesToGridview()
        {
            //Only for the main table (the rest added manually in the designer)
            foreach (DataColumn column in dataTables["Units"].Columns)
            {
                GridView_Units.Columns.Add(column.ColumnName, column.ColumnName);
            }

            //For all tables
            //foreach (string table in dataTables.Keys)
            //{
            //    foreach (TabPage tab in tabControl1.TabPages)
            //    {
            //        //TESTING
            //        if (tab == tabControl1.TabPages["tab_Units"]) { continue; }

            //        DataGridView gridView = tab.Controls["Gridview_" + table] as DataGridView;
            //        if (gridView == null) { continue; }

            //        foreach (DataColumn column in dataTables[table].Columns)
            //        {
            //            //if (gridView.Name != "Gridview_Units" && column.Ordinal == 0) { continue; }
            //            gridView.Columns.Add(column.ColumnName, column.ColumnName);
            //        }
            //    }
            //}
            GridView_Units.Columns[0].Frozen = true;
        }

        
        private void SaveDataTablesToFile(string _tableName = null, bool includeLocalizedText = false)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string tableName in dataTables.Keys)
                    {
                        if (_tableName != null && tableName != _tableName) { continue; } //If tableName != null ignore everything else
                        if (_tableName == null && includeLocalizedText == false && tableName == "LocalizedText") { continue; }
                        foreach (DataRow row in dataTables[tableName].Rows)
                        {
                            List<string> itemsToWrite = new List<string>();
                            foreach (var item in row.ItemArray)
                            {
                                if (item.GetType() == typeof(string))
                                {
                                    bool isItemNumeric = true;
                                    foreach (char c in (string)item)
                                    {
                                        if (MySQLReader.IsCharNumeric(c) == false)
                                        {
                                            isItemNumeric = false; break;
                                        }
                                    }
                                    if (isItemNumeric || item.ToString().ToUpper() == "NULL")
                                    {
                                        itemsToWrite.Add((string)item); //If item is only numeric value or Null, then don't insert "'"
                                    }
                                    else
                                    {
                                        itemsToWrite.Add("'" + ((string)item).Replace("'", "''") + "'");
                                    }

                                }
                                else if (item.GetType() == typeof(DBNull))
                                {
                                    itemsToWrite.Add("NULL");
                                }
                            }

                            //string lineToWrite = "INSERT INTO " + "\"" + tableName + "\" " +
                            //                         "VALUES " + "('" + String.Join("','", row.ItemArray) + "');";
                            string lineToWrite = "INSERT INTO " + "\"" + tableName + "\" " +
                                                     "VALUES " + "(" + String.Join(",", itemsToWrite) + ");";
                            writer.WriteLine(lineToWrite);
                        }
                    }
                }
            }
        }
        
        private void SaveGameplayDataTables()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string tableName in dataTables.Keys)
                    {
                        if (tableName == "LocalizedText") { continue; }
                        SaveFromDataTable(tableName, writer);
                    }
                }
            }
        }

        private void SaveLocalizedTextDataTable()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    SaveFromDataTable("LocalizedText", writer);
                }
            }
        }

        private void SaveFromDataTable(string tableName, StreamWriter writer)
        {
            foreach (DataRow row in dataTables[tableName].Rows)
            {
                List<string> itemsToWrite = new List<string>();
                foreach (var item in row.ItemArray)
                {
                    if (item.GetType() == typeof(string))
                    {
                        bool isItemNumeric = true;
                        foreach (char c in (string)item)
                        {
                            if (MySQLReader.IsCharNumeric(c) == false)
                            {
                                isItemNumeric = false; break;
                            }
                        }
                        if (isItemNumeric || item.ToString().ToUpper() == "NULL")
                        {
                            itemsToWrite.Add((string)item); //If item is only numeric value or Null, then don't insert "'"
                        }
                        else
                        {
                            itemsToWrite.Add("'" + ((string)item).Replace("'", "''") + "'");
                        }

                    }
                    else if (item.GetType() == typeof(DBNull))
                    {
                        itemsToWrite.Add("NULL");
                    }
                }

                //string lineToWrite = "INSERT INTO " + "\"" + tableName + "\" " +
                //                         "VALUES " + "('" + String.Join("','", row.ItemArray) + "');";
                string lineToWrite = "INSERT INTO " + "\"" + tableName + "\" " +
                                         "VALUES " + "(" + String.Join(",", itemsToWrite) + ");";
                writer.WriteLine(lineToWrite);
            }
        }

        private void SaveFile_Button_Click(object sender, EventArgs e)
        {
            SaveDataTablesToFile(includeLocalizedText: true);
        }

        private void SaveLocalizedText_Button_Click(object sender, EventArgs e)
        {
            SaveDataTablesToFile(_tableName: "LocalizedText");
        }

        private void ResetTables_Btn_Click(object sender, EventArgs e)
        {
            ResetAllTables();
        }

        private void Gridview_Units_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string unitType = gridview[0, e.RowIndex].Value?.ToString();
            CurrentUnit_Label.Text = unitType;
            Panel_Table_Units.Tag = unitType;
            Panel_Table_UnitAbilities.Tag = null;
            PrintEntriesToPanel(null, Panel_Table_UnitAbilities);

            DataGridView[] gridViews = new DataGridView[] { GridView_Unit_BuildingPrereqs, GridView_UnitReplaces,
                                    GridView_UnitUpgrades, GridView_UnitAiInfos, GridView_UnitTags};
            if (unitType != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: unitType); }
            PrintEntriesToPanel(unitType, Panel_Table_Units);
            PrintEntriesToGridviewUnitAbilities();
        }

        private void GridView_UnitAbilities_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string unitAbilityType = gridview[0, e.RowIndex].Value?.ToString();
            Panel_Table_UnitAbilities.Tag = unitAbilityType;

            DataGridView[] gridViews = new DataGridView[] { GridView_AbilityTags};
            if (unitAbilityType != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: unitAbilityType); }
            PrintEntriesToPanel(unitAbilityType, Panel_Table_UnitAbilities);
        }

        private void GridView_Modifiers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string ModifierID = gridview[0, e.RowIndex].Value?.ToString();
            CurrentModifier_Label.Text = ModifierID;
            Panel_Table_Modifiers.Tag = ModifierID;

            CurrentRequirement_Label.Text = null;                   //Similar reset for CurrentReq_Label
            Panel_Table_Requirements.Tag = null;                    //Similar reset for CurrentReq_Label
            GridView_RequirementSetRequirements.Rows.Clear();
            GridView_Requirements.Rows.Clear();
            GridView_RequirementArguments.Rows.Clear();
            PrintEntriesToPanel(entryID: null, Panel_Table_Requirements); //This resets requirements panel
                                                                          //Later it is updated by GridView_RequirementSetRequirements_RowEnter
                                                                          //Unless there is no requirement
            DataGridView[] gridViews = new DataGridView[] { GridView_ModifierArguments };
            if (ModifierID != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: ModifierID); }
            PrintEntriesToPanel(entryID: ModifierID, Panel_Table_Modifiers);
            PrintRequirementSets(ModifierID);
            
        }

        private void GridView_RequirementSets_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string RequirementSetId = gridview[0, e.RowIndex].Value?.ToString();
            
            
            DataGridView[] gridViews = new DataGridView[] { GridView_RequirementSetRequirements };
            if (RequirementSetId != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: RequirementSetId); }
        }

        private void GridView_RequirementSetRequirements_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string RequirementId = gridview[0, e.RowIndex].Value?.ToString();
            DataGridView[] gridViews = new DataGridView[] { GridView_Requirements};
            if (RequirementId != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: RequirementId); }
        }

        private void GridView_Requirements_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string RequirementId = gridview[0, e.RowIndex].Value?.ToString();
            CurrentRequirement_Label.Text = RequirementId;
            Panel_Table_Requirements.Tag = RequirementId;

            DataGridView[] gridViews = new DataGridView[] { GridView_RequirementArguments };
            if (RequirementId != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: RequirementId); }
            PrintEntriesToPanel(entryID: RequirementId, Panel_Table_Requirements);
            
        }

        private void GridView_UnitPromotionClasses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            paths.Clear();
            lastPath = null;
            Refresh();
            DataGridView gridview = sender as DataGridView;
            string PromotionClass = gridview[0, e.RowIndex].Value?.ToString();
            CurrentPromotionClass_Label.Font = new Font(myFonts.Families[0], 20);
            if (CurrentPromotionClass_Label.Text == PromotionClass) { return; }
            CurrentPromotionClass_Label.Text = PromotionClass;

            DataGridView[] gridViews = new DataGridView[] { GridView_UnitPromotions };
            if (PromotionClass != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: PromotionClass, entryColumn: 5); }
            if (PromotionClass != null) { PrintUnitPromotionsToTableLayoutPanel(PromotionClass); }


        }

        private void GridView_UnitPromotions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string PromotionType = gridview[0, e.RowIndex].Value?.ToString();
            DataGridView[] gridViews = new DataGridView[] { GridView_UnitPromotionPrereqs };
            if (PromotionType != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: PromotionType); }
        }

        private void GridView_ClassAbilities_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = sender as DataGridView;
            string UnitAbilityType = gridview[1, e.RowIndex].Value?.ToString();
            DataGridView[] gridViews = new DataGridView[] { GridView_UnitAbilities };
            if (UnitAbilityType != null) { PrintEntriesToGridviewNEW(gridViews: gridViews, entryID: UnitAbilityType); }
        }


        Point previousLocation;
        Control activeControl = null;
        bool IsLeftMouseButtonDown = false;
        bool IsRightMouseButtonDown = false;

        private void PrintUnitPromotionsToTableLayoutPanel(string promotionClass)
        {
            DataTable dt = dataTables["UnitPromotions"];
            Panel_PromotionClassPromotions.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                if (row[5].ToString() == promotionClass)
                {
                    int promotionColIndex; 
                    if (int.TryParse(row[6].ToString(), out promotionColIndex) == false) { MessageBox.Show("Error: Could not parse int from row[6] in UnitPromotions table"); return; } 
                    promotionColIndex -= 1;
                    
                    int promotionRowIndex;
                    if (int.TryParse(row[3].ToString(), out promotionRowIndex) == false) { MessageBox.Show("Error: Could not parse int from row[3] in UnitPromotions table"); return; }
                    promotionRowIndex -= 1;

                    string promotionType = row[0].ToString();
                    string promotionName = row[1].ToString();
                    string promotionDesc = row[2].ToString();

                    DataTable dtLocalizedText = null;
                    if (dataTables.ContainsKey("LocalizedText"))
                    {
                       dtLocalizedText = dataTables["LocalizedText"];
                    }
                        

                    UnitPromotionPanel panel = new UnitPromotionPanel(promotionType, promotionName, promotionDesc,
                                                                        promotionRowIndex, promotionColIndex, 
                                                                        Panel_PromotionClassPromotions.Size, 
                                                                        dtLocalizedText, myFonts);
                    Panel_PromotionClassPromotions.Controls.Add(panel);
                    

                    ContextMenuStrip panelMenuStrip = new ContextMenuStrip();
                    Panel_PromotionClassPromotions.ContextMenuStrip = panelMenuStrip;
                    panelMenuStrip.Items.Add("Clear Promotion Prereqs", null, panelMenuItem_Click);
                    panel.ContextMenuStrip = panelMenuStrip;

                    panel.DragDrop += panel_DragDrop;
                    panel.MouseDown += panel_MouseDown;
                    panel.MouseMove += panel_MouseMove;
                    panel.MouseUp += panel_MouseUp;
                    panel.DragEnter += panel_DragEnter;
                    panel.DragLeave += Panel_DragLeave;
                    panel.AllowDrop = true;


                    void panelMenuItem_Click(object sender, EventArgs e)
                    {
                        ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                        ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
                        KryptonPanel menuPanel = menu.SourceControl as KryptonPanel;
                        string promName = menuPanel.Name.Replace("PromPanel_", "");
                        List<int> rowIndexesToDelete = new List<int>();
                        
                        for (int i = 0; i < dataTables["UnitPromotionPrereqs"].Rows.Count; i++)
                        {
                            if (dataTables["UnitPromotionPrereqs"].Rows[i][0].ToString() == promName)
                            {
                                rowIndexesToDelete.Add(i);
                            }
                        }
                        rowIndexesToDelete.Sort((a, b) => b.CompareTo(a));
                        foreach (int index in rowIndexesToDelete)
                        {
                            dataTables["UnitPromotionPrereqs"].Rows[index].Delete();
                            
                        }
                        DataGridViewCell currentCell = GridView_UnitPromotions.CurrentCell;
                        GridView_UnitPromotions.CurrentCell = null;
                        GridView_UnitPromotions.CurrentCell = currentCell;
                        PrintUnitPromotionsPrereqsPaths();
                    }


                    void panel_MouseDown(object sender, MouseEventArgs e)
                    {
                        activeControl = sender as Control;
                        if (e.Button == MouseButtons.Left)
                        {
                            previousLocation = e.Location;
                            Cursor = Cursors.Hand;
                            IsLeftMouseButtonDown = true;
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            IsRightMouseButtonDown = true;
                            //((Control)sender).DoDragDrop(((Control)sender).Name, DragDropEffects.All);
                        }

                        string currentPanelPromName = activeControl.Name.Replace("PromPanel_", "");

                        foreach (DataGridViewRow promRow in GridView_UnitPromotions.Rows)
                        {
                            if (GridView_UnitPromotions[0, promRow.Index].Value?.ToString() == currentPanelPromName)
                            {
                                GridView_UnitPromotions.CurrentCell = GridView_UnitPromotions[0, promRow.Index];
                                break;
                            }
                        }
                        
                    }

                    void panel_MouseMove(object sender, MouseEventArgs e)
                    {
                        if (IsLeftMouseButtonDown)
                        {
                            if (activeControl == null || activeControl != sender)
                                return;

                            var location = activeControl.Location;
                            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
                            activeControl.Location = location;
                        }
                        else if (IsRightMouseButtonDown)
                        {
                            ((Control)sender).DoDragDrop(((Control)sender).Name, DragDropEffects.All);
                            IsRightMouseButtonDown = false;
                        }
                        
                    }

                    void panel_MouseUp(object sender, MouseEventArgs e)
                    {
                        if (activeControl == null) { return; }
                        UnitPromotionPanel upp = (UnitPromotionPanel)sender;
                        if (IsLeftMouseButtonDown)
                        {
                            int colIndex = (activeControl.Location.X - upp.firstColOffset + upp.colWidth/2) / upp.colWidth;
                            int rowIndex = (activeControl.Location.Y - upp.firstRowOffset + upp.rowHeight / 2) / upp.rowHeight;
                            activeControl.Location = new Point(upp.firstColOffset + colIndex * upp.colWidth, upp.firstRowOffset + rowIndex * upp.rowHeight);

                            string promType = (sender as Panel).Name.Replace("PromPanel_", "");
                            foreach (DataRow row2 in dataTables["UnitPromotions"].Rows)
                            {
                                if (row2[0].ToString() == promType)
                                {
                                    row2[6] = colIndex + 1;
                                    row2[3] = rowIndex + 1;
                                }
                            }
                            IsLeftMouseButtonDown = false;
                        }
                        if (IsRightMouseButtonDown) { IsRightMouseButtonDown = false; }
                        PrintUnitPromotionsPrereqsPaths();

                        activeControl = null;
                        Cursor = Cursors.Default;
                    }


                    void panel_DragDrop(object sender, DragEventArgs e)
                    {
                        //((Control)sender).BackColor = (Color)e.Data.GetData(BackColor.GetType());

                        string prereqPromType = ((string)e.Data.GetData(typeof(string))).Replace("PromPanel_", "");
                        string promType = (sender as Panel).Name.Replace("PromPanel_", "");

                        if (prereqPromType == promType) { return; }

                        DataTable tablePromPrereqs = dataTables["UnitPromotionPrereqs"];
                        bool promPrereqAlreadyExist = false;
                        foreach (DataRow row2 in tablePromPrereqs.Rows)
                        {
                            if (row2[0].ToString() == promType && row2[1].ToString() == prereqPromType)
                            {
                                promPrereqAlreadyExist = true; break;
                            }
                        }
                        if (!promPrereqAlreadyExist) { tablePromPrereqs.Rows.Add(promType, prereqPromType); }

                        paths.Add(DrawPath(activeControl as UnitPromotionPanel, sender as UnitPromotionPanel));
                        lastPath = null;
                        Refresh();
                    }

                    void panel_DragEnter(object sender, DragEventArgs e)
                    {
                        e.Effect = DragDropEffects.All;
                        //pathsTemp.Add(DrawPath(activeControl, sender as Control));
                        lastPath = DrawPath(activeControl as UnitPromotionPanel, sender as UnitPromotionPanel);
                        Refresh();
                    }

                    void Panel_DragLeave(object sender, EventArgs e)
                    {
                        lastPath = null;
                        Refresh();
                    }

                }
            }
            
            PrintUnitPromotionsPrereqsPaths();

            GraphicsPath DrawPath(UnitPromotionPanel upp, UnitPromotionPanel upp2)
            {
                if (upp == null || upp2 == null) { return null; }
                int lineLength = 14;
                int blankLength = 6;
                int blockLength = lineLength + blankLength;
                bool turnDownRight = false;
                bool turnDownLeft = false;
                bool controlsSameColumn = false;
                bool controlsSameRow = false;

                int ctrl1colIndex = (upp.Location.X - upp.firstColOffset + upp.colWidth / 2) / upp.colWidth;
                int ctrl1rowIndex = (upp.Location.Y - upp.firstRowOffset + upp.rowHeight / 2) / upp.rowHeight;
                int ctrl2colIndex = (upp2.Location.X - upp.firstColOffset + upp.colWidth / 2) / upp.colWidth;
                int ctrl2rowIndex = (upp2.Location.Y - upp.firstRowOffset + upp.rowHeight / 2) / upp.rowHeight;
                int colsDelta = Math.Abs(ctrl1colIndex - ctrl2colIndex);
                int rowsDelta = Math.Abs(ctrl1rowIndex - ctrl2rowIndex);

                int ctrl1colMid = upp.firstColOffset + upp.colWidth / 2 + ctrl1colIndex * upp.colWidth;
                int ctrl1rowMid = upp.firstRowOffset + upp.rowHeight / 2 + ctrl1rowIndex * upp.rowHeight;
                int ctrl2colMid = upp.firstColOffset + upp.colWidth / 2 + ctrl2colIndex * upp.colWidth;
                int ctrl2rowMid = upp.firstRowOffset + upp.rowHeight / 2 + ctrl2rowIndex * upp.rowHeight;

                if (ctrl1colIndex < ctrl2colIndex && ctrl1rowIndex < ctrl2rowIndex)
                { turnDownRight = true; }
                else if (ctrl1colIndex > ctrl2colIndex && ctrl1rowIndex < ctrl2rowIndex)
                { turnDownLeft = true; }
                else if (ctrl1colIndex == ctrl2colIndex) { controlsSameColumn = true; }
                else if (ctrl1rowIndex == ctrl2rowIndex) { controlsSameRow = true; }

                List<int> verticalLines = new List<int>();
                List<int> horizontalLines = new List<int>();    //List of start point of each line starting 
                                                                //in the middle of the first control
                                                                //and ending in the middle of the last control
                Point start = new Point(upp.firstColOffset + upp.colWidth / 2, upp.firstRowOffset + upp.rowHeight / 2);
                Point end = new Point(start.X + 4 * upp.colWidth, start.Y + 3 * upp.rowHeight);

                while (start.X + blockLength < end.X)
                {
                    horizontalLines.Add(start.X);
                    start.Offset(blockLength, 0);
                }
                while (start.Y + blockLength < end.Y)
                {
                    verticalLines.Add(start.Y);
                    start.Offset(0, blockLength);
                }

                int numberOfWholeBlocksInRow = upp.rowHeight / blockLength;
                int numberOfWholeBlocksInCol = upp.colWidth / blockLength;

                //int remainderX = colWidth - numberOfWholeBlocksInCol * blockLength; //= distX % blockLength;
                //int remainingDistX = 0;
                //if (remainderX > 0)  //If there is any dist remainder
                //{
                //    int blockExtraLength = remainderX / numberOfWholeBlocksInCol; //Extra length of one whole block 
                //    remainingDistX = remainderX % numberOfWholeBlocksInCol;  //The remaining distance (added later to the beginning of the path)

                //    int lineExtraLength = blockExtraLength * 2 / 3 + blockExtraLength % 3; // 2/3 of the block length + plus remainder from division by 3 
                //    int blankExtraLength = blockExtraLength - lineExtraLength;         //What is left from the above calculation
                //    lineLength += lineExtraLength;
                //    blankLength += blankExtraLength;
                //    blockLength += lineLength + blankLength;
                //}

                GraphicsPath path = new GraphicsPath();
                if (turnDownRight)
                {
                    DrawVerticalLines(ctrl1rowMid, ctrl1rowMid + upp.rowHeight / 2 - 25, ctrl1colMid);

                    path.StartFigure();
                    path.AddArc(ctrl1colMid, ctrl1rowMid + upp.rowHeight / 2 - 25 - 23, 22, 22, 180, -90);

                    DrawHorizontalLines(ctrl1colMid + blockLength, ctrl2colMid, ctrl1rowMid + upp.rowHeight / 2 - 25);

                    path.StartFigure();
                    path.AddArc(ctrl2colMid - 23, ctrl1rowMid + upp.rowHeight / 2 - 25, 22, 22, -90, 90);

                    DrawVerticalLines(ctrl1rowMid + upp.rowHeight / 2 - 25, ctrl2rowMid, ctrl2colMid);
                }
                else if (turnDownLeft)
                {
                    DrawVerticalLines(ctrl1rowMid, ctrl1rowMid + upp.rowHeight / 2 - 25, ctrl1colMid);

                    path.StartFigure();
                    path.AddArc(ctrl1colMid - 23, ctrl1rowMid + upp.rowHeight / 2 - 25 - 23, 22, 22, 0, 90);

                    DrawHorizontalLines(ctrl1colMid, ctrl2colMid + blockLength, ctrl1rowMid + upp.rowHeight / 2 - 25);

                    path.StartFigure();
                    path.AddArc(ctrl2colMid, ctrl1rowMid + upp.rowHeight / 2 - 25, 22, 22, -90, -90);

                    DrawVerticalLines(ctrl1rowMid + upp.rowHeight / 2 - 25, ctrl2rowMid, ctrl2colMid);
                }
                else if (controlsSameColumn)
                {
                    DrawVerticalLines(ctrl1rowMid, ctrl2rowMid, ctrl1colMid);
                }
                else if (controlsSameRow)
                {
                    DrawHorizontalLines(ctrl1colMid, ctrl2colMid, ctrl1rowMid);
                }
                return path;

                void DrawHorizontalLines(int x1, int x2, int y)
                {
                    if (x1 > x2)
                    {
                        int tempX1 = x1;
                        x1 = x2;
                        x2 = tempX1;
                    }

                    for (int h = 0; h < horizontalLines.Count; h++)
                    {
                        if (horizontalLines[h] < x1) { continue; }
                        if (horizontalLines[h] + blockLength >= x2) { break; }
                        path.StartFigure();
                        path.AddLine(horizontalLines[h], y, horizontalLines[h] + lineLength, y);
                    }
                }

                void DrawVerticalLines(int y1, int y2, int x)
                {
                    for (int v = 0; v < verticalLines.Count; v++)
                    {
                        if (verticalLines[v] < y1) { continue; }
                        if (verticalLines[v] + blockLength >= y2) { break; }
                        path.StartFigure();
                        path.AddLine(x, verticalLines[v], x, verticalLines[v] + lineLength);
                    }
                }


            }

            void PrintUnitPromotionsPrereqsPaths()
            {
                paths.Clear();
                foreach (UnitPromotionPanel panel in Panel_PromotionClassPromotions.Controls)
                {
                    string prereqPromName = panel.Name.Replace("PromPanel_", "");

                    //if (panel.GetType() != typeof(Panel)) { continue; }
                    foreach (DataRow row in dataTables["UnitPromotionPrereqs"].Rows)
                    {
                        if (row[1].ToString() != prereqPromName) { continue; }
                        string promName = row[0].ToString();
                        UnitPromotionPanel panel2 = Panel_PromotionClassPromotions.Controls["PromPanel_" + promName] as UnitPromotionPanel;
                        paths.Add(DrawPath(panel, panel2));
                    }
                }
                Refresh();
            }

        }


        //Adding custom fonts: (Best solution by Reza Taibur)
        //https://stackoverflow.com/questions/1297264/using-custom-fonts-on-a-label-on-winforms
        PrivateFontCollection myFonts = new PrivateFontCollection();
        private void CustomFont()
        {
            //OPTION 1:
            myFonts.AddFontFile(@"Resources\Fonts\Elan ITC Std Book.otf");
            myFonts.AddFontFile(@"Resources\Fonts\Minion Pro Medium.ttf");
            myFonts.AddFontFile(@"Resources\Fonts\Minion Pro Semibold.ttf");
            myFonts.AddFontFile(@"Resources\Fonts\Myriad Pro Regular.ttf");
            myFonts.AddFontFile(@"Resources\Fonts\Myriad Pro Semibold.ttf");
        }


        private void ChangeLocalizedText(string tag, string text, string language = "en_US", 
                                         string gender = null, string plurality = null)
        {
            if (!dataTables.ContainsKey("LocalizedText")) { return; }
            DataTable dt = dataTables["LocalizedText"];
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == language && row[1].ToString() == tag)
                {
                    row[2] = text;
                    row[3] = gender;
                    row[4] = plurality;
                    return;
                }
            }
            if (chbx_AddNewTexts.Checked)
            {
                DataRow newRow = dt.NewRow();
                newRow[0] = language; newRow[1] = tag; newRow[2] = text; newRow[3] = gender; newRow[4] = plurality;
                dt.Rows.Add(newRow);
            }
        }
        

        

        private void AddMainDatabase_Btn_Click(object sender, EventArgs e)
        {
            //CreateDataTablesFromSQLFile();
            //PrintDataTablesToGridview();

            //AddEntriesToDataTables();
            AddEntriesToDataTables();
            PrintDataTablesToGridview();
            PrintEntriesToGridview();

            SubscribeToEditCellForAllTables();
            SubscribeToEditControlForAllTablePanels();

        }

        private void AddLocalizationFile_Btn_Click(object sender, EventArgs e)
        {
            //CreateDataTablesFromSQLFile();
            //AddEntriesToDataTables();
            AddEntriesToDataTables();
        }

        private void AllComboBoxes_Click(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            DataTable dt = null;
            if (cbx == cbx_Modifier_ModifierType) { dt = dataTables["DynamicModifiers"]; }
            else if (cbx == cbx_Modifier_OwnerRequirementSetID) { dt = dataTables["RequirementSets"]; }
            else if (cbx == cbx_Modifier_SubjectRequirementSetID) { dt = dataTables["RequirementSets"]; }
            else if (cbx == cbx_Requirement_RequirementType) { dt = dataTables["Types"]; }
            
            foreach (DataRow row in dt.Rows)
            {
                //With RequirementType the table is Types where ALL different kinds of objects are located
                //So we need to check first if column Kind is "KIND_REQUIREMENT"
                if (cbx == cbx_Requirement_RequirementType && row["Kind"].ToString() != "KIND_REQUIREMENT")
                { continue; }

                string rowText = row[0].ToString();
                if (!cbx.Items.Contains(rowText))
                {
                    cbx.Items.Add(rowText);
                }
            }
            if (cbx == cbx_Modifier_OwnerRequirementSetID || cbx == cbx_Modifier_SubjectRequirementSetID)
            {
                if (!cbx.Items.Contains("NULL"))
                {
                    cbx.Items.Add("NULL"); //These columns can contain NULL as a value (meaning no Requirement Set)
                }
            }
        }

        private void AllKryptonComboBoxes_Enter(object sender, EventArgs e)
        {
            KryptonComboBox cbx = sender as KryptonComboBox;
            string tableName = null;
            DataTable dt = null;
            if (cbx == cbx_Unit_PseudoYieldType) { tableName = "PseudoYields"; }
            else if (cbx == cbx_Unit_PurchaseYield) { tableName = "Yields"; }
            else if (cbx == cbx_Unit_LeaderType) { tableName = "Leaders"; }
            else if (cbx == cbx_Unit_FormationClass) { tableName = "UnitFormationClasses"; }
            else if (cbx == tbx_Unit_Flavor) { tableName = "Flavors"; }
            else if (cbx == cbx_Unit_PromotionClass) { tableName = "UnitPromotionClasses"; }
            else if (cbx == tbx_Unit_TraitType) { tableName = "Traits"; }
            else if (cbx == cbx_Unit_PrereqDistrict) { tableName = "Districts"; }
            else if (cbx == cbx_Unit_StrategicResource || cbx == cbx_Unit_XP2_ResourceMaintenanceType) 
            { tableName = "Resources"; }
            else if (cbx == cbx_Unit_PrereqTech || cbx == cbx_Unit_ObsoleteTech || cbx == cbx_Unit_MandatoryObsoleteTech) 
            { tableName = "Technologies"; }
            else if (cbx == cbx_Unit_PrereqCivic || cbx == cbx_Unit_ObsoleteCivic || cbx == cbx_Unit_MandatoryObsoleteCivic)
            { tableName = "Civics"; }

            //The following do not have their own table to choose items from, need to add manually below
            if (cbx == tbx_Unit_CostProgressionModel) 
            {
                if (!cbx.Items.Contains("NO_COST_PROGRESSION")) { cbx.Items.Add("NO_COST_PROGRESSION"); }
                if (!cbx.Items.Contains("NO_PROGRESSION_MODEL")) { cbx.Items.Add("NO_PROGRESSION_MODEL"); } //Different for Projects...
                if (!cbx.Items.Contains("COST_PROGRESSION_GAME_PROGRESS")) { cbx.Items.Add("COST_PROGRESSION_GAME_PROGRESS"); }
                if (!cbx.Items.Contains("COST_PROGRESSION_PREVIOUS_COPIES")) { cbx.Items.Add("COST_PROGRESSION_PREVIOUS_COPIES"); }
                if (!cbx.Items.Contains("COST_PROGRESSION_NUM_UNDER_AVG_PLUS_TECH")) { cbx.Items.Add("COST_PROGRESSION_NUM_UNDER_AVG_PLUS_TECH"); }
                return;
            }
            else if (cbx == cbx_Unit_AdvisorType)
            {
                if (!cbx.Items.Contains("NULL")) { cbx.Items.Add("NULL"); }
                if (!cbx.Items.Contains("ADVISOR_GENERIC")) { cbx.Items.Add("ADVISOR_GENERIC"); }
                if (!cbx.Items.Contains("ADVISOR_CONQUEST")) { cbx.Items.Add("ADVISOR_CONQUEST"); }
                if (!cbx.Items.Contains("ADVISOR_CULTURE")) { cbx.Items.Add("ADVISOR_CULTURE"); }
                if (!cbx.Items.Contains("ADVISOR_TECHNOLOGY")) { cbx.Items.Add("ADVISOR_TECHNOLOGY"); }
                if (!cbx.Items.Contains("ADVISOR_RELIGIOUS")) { cbx.Items.Add("ADVISOR_RELIGIOUS"); }
                return;
            }
            else if (cbx == cbx_Unit_Domain) // || cbx == cbx_District_MilitaryDomain
            {
                if (!cbx.Items.Contains("DOMAIN_LAND")) { cbx.Items.Add("DOMAIN_LAND"); }
                if (!cbx.Items.Contains("DOMAIN_SEA")) { cbx.Items.Add("DOMAIN_SEA"); }
                if (!cbx.Items.Contains("DOMAIN_AIR")) { cbx.Items.Add("DOMAIN_AIR"); }
                if (cbx != cbx_Unit_Domain && !cbx.Items.Contains("NO_DOMAIN")) { cbx.Items.Add("NO_DOMAIN"); } //Only for District's Military Domain
                return;
            }

            if (tableName == null) { return; }
            if (!dataTables.ContainsKey(tableName)) { MessageBox.Show("There is no " + tableName + " table in the database."); return; }
            dt = dataTables[tableName];

            if (dt == null) { MessageBox.Show("This ComboBox' list is not yet implemented"); return; }
            foreach (DataRow row in dt.Rows)
            {
                string rowText = row[0].ToString();
                if (!cbx.Items.Contains(rowText))
                {
                    cbx.Items.Add(rowText);
                }
            }
            if (cbx != cbx_Unit_Domain && cbx != cbx_Unit_FormationClass && cbx != tbx_Unit_CostProgressionModel)
            {
                if (!cbx.Items.Contains("NULL"))
                {
                    cbx.Items.Add("NULL"); //These columns can contain NULL as a value
                }
            }
        }


        Dictionary<string, string> TypeKindPairsInTypes = new Dictionary<string, string>()
        {
            { "Beliefs"                  , "KIND_BELIEF"                   },
            { "Buildings"                , "KIND_BUILDING"                 },
            { "Civics"                   , "KIND_CIVIC"                    },
            { "Civilizations"            , "KIND_CIVILIZATION"             },
            { "Defeats"                  , "KIND_DEFEAT"                   },
            { "DiplomaticActions"        , "KIND_DIPLOMATIC_ACTION"        },
            { "Districts"                , "KIND_DISTRICT"                 },
            { "DynamicModifiers"         , "KIND_MODIFIER"                 },
            { "Eras"                     , "KIND_ERA"                      },
            { "Features"                 , "KIND_FEATURE"                  },
            { "GameCapabilities"         , "KIND_CAPABILITY"               },
            { "Gossips"                  , "KIND_GOSSIP"                   },
            { "Governments"              , "KIND_GOVERNMENT"               },
            { "GreatPersonClasses"       , "KIND_GREAT_PERSON_CLASS"       },
            { "GreatPersonIndividuals"   , "KIND_GREAT_PERSON_INDIVIDUAL"  },
            { "Improvements"             , "KIND_IMPROVEMENT"              },
            { "Leaders"                  , "KIND_LEADER"                   },
            { "LoadingInfo"              , "KIND_LEADER"                   },
            { "Policies"                 , "KIND_POLICY"                   },
            { "Projects"                 , "KIND_PROJECT"                  },
            { "PseudoYields"             , "KIND_PSEUDOYIELD"              },
            { "Quests"                   , "KIND_QUEST"                    },
            { "Religions"                , "KIND_RELIGION"                 },
            { "Resources"                , "KIND_RESOURCE"                 },
            { "Routes"                   , "KIND_ROUTE"                    },
            { "Technologies"             , "KIND_TECH"                     },
            { "Terrains"                 , "KIND_TERRAIN"                  },
            { "Traits"                   , "KIND_TRAIT"                    },
            { "Units"                    , "KIND_UNIT"                     },
            { "UnitAbilities"            , "KIND_ABILITY"                  },
            { "UnitCommands"             , "KIND_UNITCOMMAND"              },
            { "UnitFormationClasses"     , "KIND_FORMATION_CLASS"          },
            { "UnitOperations"           , "KIND_UNITOPERATION"            },
            { "UnitPromotions"           , "KIND_PROMOTION"                },
            { "UnitPromotionClasses"     , "KIND_PROMOTION_CLASS"          },
            { "Victories"                , "KIND_VICTORY"                  },
            { "Strategies"               , "KIND_VICTORY_STRATEGY"         },
            { "WMDs"                     , "KIND_WMD"                      },
            { "Yields"                   , "KIND_YIELD"                    },
            { "ScoringLineItems"         , "KIND_SCORING_LINE_ITEM"        },
            { "GovernmentSlots"          , "KIND_SLOT"                     },
            { "TurnTimers"               , "KIND_TURNTIMER"                },
            { "BarbarianTribeNames"      , "KIND_BARBARIAN_TRIBE"          },
            { "Continents"               , "KIND_CONTINENT"                },
            { "DealItems"                , "KIND_DEAL_ITEM"                },
            { "Difficulties"             , "KIND_DIFFICULTY"               },
            { "DiplomaticStates"         , "KIND_DIPLOMATIC_STATE"         },
            { "GameSpeeds"               , "KIND_GAMESPEED"                },
            { "GameSpeed_Scalings"       , "KIND_GAMESPEED_SCALING"        },
            { "GoodyHuts"                , "KIND_GOODY_HUT"                },
            { "GreatWorks"               , "KIND_GREATWORK"                },
            { "Happinesses"              , "KIND_HAPPINESS"                },
            { "Maps"                     , "KIND_MAPSIZE"                  },
            { "Notifications"            , "KIND_NOTIFICATION"             }
        };

        private void AllAddObjectButtons_MainTables_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Control buttonContainer = btn.Parent;
            Panel oldPanel;
            if ((oldPanel = buttonContainer.Controls["AddNewObject_Panel"] as Panel) != null) { oldPanel.Dispose(); return; }
            
            Panel panel = new Panel();
            panel.Name = "AddNewObject_Panel";
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = SystemColors.ControlLight;
            panel.Location = new Point(btn.Location.X, btn.Location.Y + btn.Height);
            
            TextBox tbx; Button btnOK; Button btnCancel;
            panel.Controls.Add(tbx = new TextBox());
            panel.Controls.Add(btnOK = new Button());
            panel.Controls.Add(btnCancel = new Button());

            tbx.Size = new Size(300, 25);
            tbx.Font = new Font("Microsoft Sans Serif", 14);
            tbx.Location = new Point(tbx.Left + 10, tbx.Top + 6);
            tbx.BorderStyle = BorderStyle.None;
            btnOK.Location = new Point(tbx.Location.X + tbx.Width, tbx.Location.Y);
            btnOK.Size = new Size(75, 22);
            btnOK.Text = "OK";
            btnCancel.Location = new Point(btnOK.Location.X + btnOK.Width, btnOK.Location.Y);
            btnCancel.Size = btnOK.Size;
            btnCancel.Text = "Cancel";

            panel.Size = new Size(tbx.Width + btnOK.Width + btnCancel.Width + 20, 35);

            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;

            buttonContainer.Controls.Add(panel);
            panel.BringToFront();

            void BtnOK_Click(object sender_OK, EventArgs e_OK)
            {
                string newObjectId = tbx.Text;
                if (string.IsNullOrEmpty(newObjectId)) { MessageBox.Show("Empty"); return; }

                DataTable dt = null; DataGridView gridView = null;
                string tableName = btn.Name.Replace("Add", "").Replace("_Btn", "s");
                dt = dataTables[tableName];
                gridView = tabControl1.SelectedTab.Controls["GridView_" + tableName] as DataGridView;

                //if (btn == AddModifier_Btn) { dt = dataTables["Modifiers"]; gridView = GridView_Modifiers; }
                //else if (btn == AddRequirement_Btn) { dt = dataTables["Requirements"]; gridView = GridView_Requirements; }
                //else if (btn == AddRequirementSet_Btn) { dt = dataTables["RequirementSets"]; gridView = GridView_RequirementSets; }
                //else if (btn == AddModifierArgument_Btn) { dt = dataTables["ModifierArguments"]; gridView = GridView_ModifierArguments; }
                //else if (btn == AddRequirementArgument_Btn) { dt = dataTables["RequirementArguments"]; gridView = GridView_RequirementArguments; }


                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == newObjectId) { MessageBox.Show("Already Exists"); return; }
                }
                DataRow newRow = dt.NewRow(); //dt.Rows.Add() throws an error in UnitAbilities table (UnitAbilityType cannot be null)
                newRow[0] = newObjectId;

                if (btn == AddRequirementSet_Btn)
                {
                    newRow[1] = "REQUIREMENTSET_TEST_ALL";         //RequirementSetType
                }
                else if (btn == AddUnit_Btn)
                {
                    newRow[1] = "LOC_" + newObjectId + "_NAME";         //Name
                    newRow[24] = "LOC_" + newObjectId + "_DESCRIPTION"; //Description
                }
                else if (btn == AddUnitPromotionClasse_Btn)
                {
                    newRow[1] = "LOC_" + newObjectId + "_NAME";         //Name
                }
                else if (btn == AddUnitPromotion_Btn) 
                {
                    newRow[1] = "LOC_" + newObjectId + "_NAME";         //Name
                    newRow[2] = "LOC_" + newObjectId + "_DESCRIPTION";  //Description
                    newRow[3] = "0";                                    //Level
                    newRow[4] = "NULL";                                 //Specialization
                    newRow[5] = CurrentPromotionClass_Label.Text;       //Prom Class
                    newRow[6] = "0";                                    //Column
                }  
                else if (btn == AddUnitAbilitie_Btn)
                {
                    newRow[1] = "LOC_" + newObjectId + "_NAME";         //Name
                    newRow[2] = "LOC_" + newObjectId + "_DESCRIPTION";  //Description
                    newRow[3] = "0";                                    //Inactive
                    newRow[4] = "0";                                    //ShowFloatTextWhenEarned
                    newRow[5] = "1";                                    //Permanent
                }
                dt.Rows.Add(newRow);    //if dt.NewRow() is used earlier, then we need to add this newRow this way
                
                //For the tables that require it (in TableKindPairsInTypes) add a new Type
                if (TypeKindPairsInTypes.ContainsKey(tableName))
                {
                    DataRow row = dataTables["Types"].Rows.Add();
                    row[0] = newObjectId;
                    row[2] = TypeKindPairsInTypes[tableName];
                }


                //------    OPTION 1    ------
                //Simply add a row to the GridView when it is added to the DataTable
                //By far the fastest, but does not update rows based on the DataTable
                //----------------------------
                int gridRowIndex = gridView.Rows.Add(newRow.ItemArray);
                //gridView[0, gridRowIndex].Value = newObjectId;

                //------    OPTION 2    ------ 
                //NOT clearing rows, just changes values according to what is in the DataTable
                //Pretty fast, but does not clear rows and cannot add too many rows - program freezes
                //(but only with a few thousand rows)
                //----------------------------
                //for (int i = 0; i < dataTables["Modifiers"].Rows.Count; i++)
                //{
                //    foreach (DataGridViewColumn col in GridView_Modifiers.Columns)
                //    {
                //        if (GridView_Modifiers.Rows.Count < i + 1) { GridView_Modifiers.Rows.Add(); }

                //        GridView_Modifiers[col.Index, i].Value = dataTables["Modifiers"].Rows[i][col.HeaderText].ToString();
                //    }
                //}

                //------    OPTION 3    ------
                //After clearing rows, add each one from the DataTable (need to Add(row.ItemArray)
                //Although later I change the values anyway
                //As strange as it may be, adding any other value or an empty row does not work - program freezes
                //Takes longest, but makes sure every time rows are added as they are in the DataTable
                //----------------------------
                //GridView_Modifiers.Rows.Clear();
                //foreach (DataRow row in dataTables["Modifiers"].Rows)
                //{
                //    int gridRowIndex = GridView_Modifiers.Rows.Add(row.ItemArray); //For a strange reason there the programm freezes if I don't add row.ItemArray in the row

                //    foreach (DataGridViewColumn col in GridView_Modifiers.Columns)
                //    {
                //        GridView_Modifiers[col.Index, gridRowIndex].Value = row[col.HeaderText].ToString();
                //    }
                //}
                GridView_Modifiers.ClearSelection();

                panel.Dispose();
            }
            void BtnCancel_Click(object sender_Cancel, EventArgs e_Cancel)
            {
                panel.Dispose();
            }
        }

        private void AllAddObjectButtons_SecondaryTables_Click(object sender, EventArgs e)
        {
            ComboBox oldCbx;
            if ((oldCbx = tabControl1.SelectedTab.Controls["AddObject_Cbx"] as ComboBox) != null) { oldCbx.Dispose(); }

            Button btn = sender as Button;
            ComboBox cbx = new ComboBox();

            string gridViewName = btn.Name.Replace("Add", "GridView_").Replace("_Btn", "s");
            DataGridView gridView = tabControl1.SelectedTab.Controls[gridViewName] as DataGridView;

            DataTable dt;
            if (btn == AddUnitTag_Btn || btn == AddAbilityTag_Btn) { dt = dataTables["TypeTags"]; }
            else { dt = dataTables[gridViewName.Replace("GridView_", "")]; }
            
            cbx.Name = "AddObject_Cbx";
            cbx.Location = btn.Location;
            cbx.DropDownWidth = 450;

            DataTable sourceTable = null; int sourceTableRow = 0; //Source table for possible items list to choose from 
            if (btn == AddModifierArgument_Btn 
                  || btn == AddRequirementArgument_Btn)         { sourceTable = dt; sourceTableRow = 1; }
            else if (btn == AddUnitReplace_Btn 
                || btn == AddUnitUpgrade_Btn)                   { sourceTable = dataTables["Units"]; }
            else if (btn == AddUnitTag_Btn
                || btn == AddAbilityTag_Btn)                    { sourceTable = dataTables["Tags"]; }
            else if (btn == AddRequirementSetRequirement_Btn)   { sourceTable = dataTables["Requirements"]; }
            else if (btn == AddUnit_BuildingPrereq_Btn)         { sourceTable = dataTables["Buildings"];  }
            else if (btn == AddUnitAiInfo_Btn)                  { sourceTable = dataTables["UnitAiTypes"];  }
            

            foreach (DataRow row in sourceTable.Rows)
            {
                string rowText = row[sourceTableRow].ToString();
                if (!cbx.Items.Contains(rowText))
                {
                    cbx.Items.Add(rowText);
                }
            }

            cbx.Sorted = true;
            tabControl1.SelectedTab.Controls.Add(cbx);
            cbx.Focus();
            cbx.DroppedDown = true;

            cbx.SelectionChangeCommitted += Cbx_SelectionChangeCommitted;

            void Cbx_SelectionChangeCommitted(object sender2, EventArgs e2)
            {
                string selectedItemText = cbx.SelectedItem.ToString();
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    string gridRowText = row.Cells[0].Value?.ToString();
                    if (gridRowText == selectedItemText)
                    {
                        MessageBox.Show("Already Exists"); return;
                    }
                }
                string currentObject = null;
                if (btn == AddUnitReplace_Btn || btn == AddUnitUpgrade_Btn || btn == AddUnit_BuildingPrereq_Btn 
                    || btn == AddUnitAiInfo_Btn || btn == AddUnitTag_Btn) { currentObject = CurrentUnit_Label.Text; }
                else if (btn == AddModifierArgument_Btn) { currentObject = CurrentModifier_Label.Text; }
                else if (btn == AddRequirementArgument_Btn) { currentObject = CurrentRequirement_Label.Text; }
                else if (btn == AddRequirementSetRequirement_Btn) 
                { currentObject = GridView_RequirementSets.CurrentRow?.Cells[0].Value?.ToString(); }
                else if (btn == AddAbilityTag_Btn) 
                { currentObject = GridView_UnitAbilities.CurrentRow?.Cells[0].Value?.ToString(); }

                if (currentObject == null) { MessageBox.Show("The object to which you are trying to add this entry is null"); return; }

                dt.Rows.Add(currentObject, selectedItemText);
                gridView.Rows.Add(selectedItemText);

                cbx.Dispose();
            }
        }

        private void AllGridViews_MainTables_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) { return; }
            if (e.RowIndex < 0) { return; } //Column headers have rowIndex = -1
            
            DataGridView gridView = sender as DataGridView;
            gridView.CurrentCell = gridView[e.ColumnIndex, e.RowIndex]; //Without it right button click does not select cell

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Show All Items in Table", null, MenuItem_ShowAllItems_Click, "menuItem_ShowAllItems"));
            contextMenu.Items.Add(new ToolStripMenuItem("Delete", null, MenuItem_DeleteObject_Click, "menuItem_DeleteObject"));
            contextMenu.Show(Cursor.Position);

            void MenuItem_ShowAllItems_Click(object senderMenuItem, EventArgs eMenuItem)
            {
                gridView.Rows.Clear();
                string tableName = gridView.Name.Replace("GridView_", "");
                foreach (DataRow row in dataTables[tableName].Rows)
                {
                    int gridRowIndex = gridView.Rows.Add(); //For a strange reason there is an error when adding an empty row, so I needed to add ""
                    for (int i = 0; i < gridView.ColumnCount; i++)
                    {
                        gridView[i, gridRowIndex].Value = row[gridView.Columns[i].HeaderText].ToString();
                    }
                }
                gridView.CurrentCell = null;
            }

            void MenuItem_DeleteObject_Click(object senderMenuItem, EventArgs eMenuItem)
            {
                string tableName = gridView.Name.Replace("GridView_", "");
                string currentObjectText = gridView[0, e.RowIndex].Value?.ToString();

                //Delete the object from the corresponding table
                foreach (DataRow row in dataTables[tableName].Rows)
                {
                    if (row[0].ToString() == currentObjectText)
                    {
                        row.Delete();
                        break;
                    }
                }
                //Delete the object from table Types
                if (TypeKindPairsInTypes.ContainsKey(tableName))
                {
                    foreach (DataRow row2 in dataTables["Types"].Rows)
                    {
                        if (row2[0].ToString() == currentObjectText)
                        {
                            row2.Delete();
                            break;
                        }
                    }
                }
                //Delete the row containing the object from gridview
                gridView.Rows.RemoveAt(e.RowIndex);
            }

        }

        private void AllGridViews_SecondaryTables_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) { return; }
            if (e.RowIndex < 0) { return; } //Column headers have rowIndex = -1

            DataGridView gridView = sender as DataGridView;
            gridView.CurrentCell = gridView[e.ColumnIndex, e.RowIndex]; //Without it right button click does not select cell

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Delete", null, MenuItem_DeleteObject_Click, "menuItem_DeleteObject"));
            contextMenu.Show(Cursor.Position);

            void MenuItem_DeleteObject_Click(object senderMenuItem, EventArgs eMenuItem)
            {
                string tableName = gridView.Name.Replace("GridView_", "");
                string currentObjectText = gridView[0, e.RowIndex].Value?.ToString();
                string baseTableObjectText = null;

                if (gridView == GridView_RequirementArguments)  
                {  baseTableObjectText = CurrentRequirement_Label.Text;  } 
                else if (gridView == GridView_ModifierArguments)  
                {  baseTableObjectText = CurrentModifier_Label.Text;  }
                else if (gridView == GridView_RequirementSetRequirements) 
                {  baseTableObjectText = GridView_RequirementSets.CurrentRow?.Cells[0].Value?.ToString(); }
                else if (gridView == GridView_UnitPromotionPrereqs)  
                {  baseTableObjectText = GridView_UnitPromotions.CurrentRow?.Cells[0].Value?.ToString(); }
                else if (gridView == GridView_AbilityTags)
                { baseTableObjectText = GridView_UnitAbilities.CurrentRow?.Cells[0].Value?.ToString(); }
                else if (gridView == GridView_Unit_BuildingPrereqs || gridView == GridView_UnitReplaces
                        || gridView == GridView_UnitTags || gridView == GridView_UnitUpgrades
                        || gridView == GridView_UnitAiInfos) 
                {  baseTableObjectText = CurrentUnit_Label.Text; }

                DataTable dt;
                if (gridView == GridView_UnitTags || gridView == GridView_AbilityTags) { dt = dataTables["TypeTags"]; }
                else { dt = dataTables[gridView.Name.Replace("GridView_", "")]; }

                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == baseTableObjectText)
                    {
                        if (row[1].ToString() == currentObjectText)
                        {
                            row.Delete();
                            break;
                        }
                    }
                }
                gridView.Rows.RemoveAt(e.RowIndex);
            }
        }


        List<GraphicsPath> paths = new List<GraphicsPath>();
        GraphicsPath lastPath = null;

        private void Panel_PromotionClassPromotions_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (var path in paths)
            {
                if (path == null) {  continue; }
                e.Graphics.DrawPath(new Pen(Color.FromArgb(255, 56, 77, 95), 4), path);
            }
            
            if (lastPath != null)
            {
                e.Graphics.DrawPath(new Pen(Color.FromArgb(255, 96, 117, 135), 4), lastPath);
                lastPath = null;
            }
            
        }

        private void GetColorUnderCursor()
        {
            using (var bmp = new Bitmap(1, 1))
            using (var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(Cursor.Position, Point.Empty, new Size(1, 1));
                var m_CurrentColor = bmp.GetPixel(0, 0);
                MessageBox.Show(m_CurrentColor.ToString());
                panel1.BackColor = m_CurrentColor;
            }
        }

        private void AllCheckboxes_CheckedChanged_ImageList(object sender, EventArgs e)
        {
            CheckBox snd = sender as CheckBox;
            if (snd.Checked) //This is the state AFTER CheckedChanged event
            {
                snd.Image = IconsGeneral_ImageList.Images[0];
            }
            else
            {
                snd.Image = IconsGeneral_ImageList.Images[1];
            }
        }
        private void AllCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            //Using imageList is more convenient but it distorts the image, displaying a weird white border around it
            //(even with 32bit ColorDepth). It possibly is caused by semi-transparent pixels around the edges of the picture
            CheckBox snd = sender as CheckBox;
            if (snd == chbx_AddNewTexts && snd.Checked)
            {
                string caption = "Are you sure you want to continue?";
                string text = "Checking this CheckBox will allow the programme to insert new rows into the LocalizedText table " +
                    "if it does not find a matching text for Unit/Ability/Modifier/etc. Name or Description. \n\n" +
                    "It works like this: once you edit (change text) in the Name or Description textbox (and if LocalizedText table " +
                    "exists in the database) the programme will search for the entry in LocalizedText matching currently chosen " +
                    "Unit/Ability/Modifier/etc. Name or Description. \n" +
                    "If this checkbox is NOT checked and the programme does not find the entry, " +
                    "it will ignore any changes made to the textbox' text. \n" +
                    "If this checkbox IS checked and the programme does not find the entry, " +
                    "it will add a new entry to the LocalizedText table with " +
                    "tag = LOC_entryType_NAME/DESCRIPTION and text = textbox content \n\n" +
                    "WARNING: Because of the way the programme works, if this checkbox is checked and you change the currently selected " +
                    "Unit/Ability/etc. AND the programme does not find the corresponding entry, it will automatically add a new entry " +
                    "with tag equal to the usual tag (as above) BUT with the text also equal to the tag \n" +
                    "So it is advisable to uncheck this checkbox before changing currently chosen Unit/Ability/etc. and check it " +
                    "only if you really want to add a new entry (e.g. when creating a new unit which does not have a LocalizedText " +
                    "Name or Description yet.";
                if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    snd.Checked = false; return;
                }
            }

            if (snd.Checked) //This is the state AFTER CheckedChanged event
            {
                snd.Image = Image.FromFile(@"Resources\Icons\tick_18x18.png");
            }
            else
            {
                snd.Image = Image.FromFile(@"Resources\Icons\cross_18x18.png");
            }
        }

        private void GridView_AdjustHeight(DataGridView gridView)
        {
            int height = (gridView.ColumnHeadersVisible ? gridView.ColumnHeadersHeight : 0); //+
            //gridView.Rows.OfType<DataGridViewRow>().Where(r => r.Visible).Sum(r => r.Height);

            int rowsHeight = 0;
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                if (i >= 5) { break; }
                rowsHeight += gridView.Rows[i].Height;
            }

            gridView.Size = new Size(gridView.Width, height + rowsHeight);
            if (gridView.Rows.Count > 5) { gridView.ScrollBars = ScrollBars.Vertical; }
            else { gridView.ScrollBars = ScrollBars.None; }
        }

        private void GridView_Unit_BuildingPrereqs_Enter(object sender, EventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            GridView_AdjustHeight(gridView);
        }

        private void GridView_Unit_BuildingPrereqs_Leave(object sender, EventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            int height = (gridView.ColumnHeadersVisible ? gridView.ColumnHeadersHeight : 0) +
                gridView.RowTemplate.Height;
            gridView.Size = new Size(gridView.Width, height);
        }

        private void GridView_Unit_BuildingPrereqs_MouseEnter(object sender, EventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            GridView_AdjustHeight(gridView);
        }

        private void GridView_Unit_BuildingPrereqs_MouseLeave(object sender, EventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (!gridView.Focused)
            {
                int height = (gridView.ColumnHeadersVisible ? gridView.ColumnHeadersHeight : 0) +
                gridView.RowTemplate.Height;
                gridView.Size = new Size(gridView.Width, height);
            }
        }

        private void GridView_Unit_BuildingPrereqs_Scroll(object sender, ScrollEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                int lastRowIndex = gridView.Rows.Count - 1;
                int firstDisplayedRowIndex = gridView.FirstDisplayedScrollingRowIndex;
                if (lastRowIndex != -1 && gridView.Rows[lastRowIndex].Displayed)
                {
                    if (firstDisplayedRowIndex > 0)
                    {
                        gridView.FirstDisplayedScrollingRowIndex = firstDisplayedRowIndex - 1;
                        //MessageBox.Show("LastRowIndex: " + lastRowIndex.ToString() + "\nFirstDisplayedRow: " + firstDisplayedRowIndex);
                    }
                }
            }
        }
    }
}
