using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civ6ModdingTool
{
    public partial class Form1 : Form
    {
        private class UnitPromotionPanel : KryptonPanel
        {
            //panel.BackColor = Color.FromArgb(255, 15, 43, 67); //Main Color of the whole panel
            //panel.BackColor = Color.FromArgb(255, 13, 31, 43);    //Inactive panel top
            //panel.BackColor = Color.FromArgb(255, 18, 43, 56);    //Inactive panel bottom
            //panel.BackColor = Color.FromArgb(255, 9, 44, 72);    //Active panel top
            //panel.BackColor = Color.FromArgb(255, 15, 70, 111);    //Active panel bottom
            //panel.BackColor = Color.FromArgb(255, 16, 104, 140);    //Active panel border
            //panel.BackColor = Color.FromArgb(255, 56, 77, 95);    //Paths
            //panel.BackColor = Color.FromArgb(255, 214, 214, 214);    //Text

            //Fonts for Description:
            //"Sitka Banner", 11            //+++ //Most text but quite big spacing between lines
            //"Cambria", 11                 //+++   //Less text, although less spacing between lines so more lines visible
            //"Corbel", 11                  //++
            //"Tw Cen MT", 11               //+
            //"Baskerville Old Face", 11  //-
            //"Footlight MT Light", 11      //_    //Very condensed but still readable
            //"Marlett", 11                 //"0" in this font looks like _ which could be used as paths

            public int firstColOffset;
            public int firstRowOffset;
            public int colWidth;
            public int rowHeight;
            public int panelWidth;
            public int panelHeight;

            public UnitPromotionPanel(string promotionType, string promotionName, string promotionDesc, 
                                        int promotionRowIndex, int promotionColIndex, 
                                        Size parentPanelSize, DataTable dtLocalizedText, PrivateFontCollection fonts)
            {
                firstColOffset = 25;
                firstRowOffset = 25;
                colWidth = (parentPanelSize.Width - 4 * firstColOffset) / 5;    //~150
                panelWidth = (14 * colWidth) / 10;                              //~210
                rowHeight = (parentPanelSize.Height - 2 * firstRowOffset) / 4;  //~145;
                panelHeight = (10 * rowHeight) / 14;                            //~100

                int descTxbWidth = panelWidth - 20;
                int descTxbHeight = (panelHeight - 10) * 3/4;
                int nameTxbWidth = descTxbWidth * 3/4;
                int nameTxbHeight = (panelHeight - 10) * 1/4;
                int iconWidth = descTxbWidth * 1/4;
                int iconHeight = nameTxbHeight;

                string promName_Loc = null;
                string promDesc_Loc = null;

                KryptonPanel panel = this;
                panel.BorderStyle = BorderStyle.None;
                panel.BackColor = Color.FromArgb(255, 15, 70, 111);
                panel.Size = new Size(panelWidth, panelHeight);
                panel.StateCommon.Color1 = Color.FromArgb(255, 9, 44, 72);
                panel.StateCommon.Color2 = Color.FromArgb(255, 15, 70, 111);
                panel.StateCommon.ColorStyle = PaletteColorStyle.Dashed;

                
                panel.Location = promotionColIndex == -1 ? new Point(parentPanelSize.Width * 2 / 5, parentPanelSize.Height * 2 / 5) 
                    : new Point(firstColOffset + colWidth * promotionColIndex, firstRowOffset + rowHeight * promotionRowIndex);
                panel.Name = "PromPanel_" + promotionType;

                if (dtLocalizedText != null)
                {
                    foreach (DataRow rowLoc in dtLocalizedText.Rows)
                    {
                        if (rowLoc[1].ToString() == promotionName)
                        {
                            promName_Loc = rowLoc[2].ToString();
                            break;
                        }
                    }
                    foreach (DataRow rowLoc in dtLocalizedText.Rows)
                    {
                        if (rowLoc[1].ToString() == promotionDesc)
                        {
                            promDesc_Loc = rowLoc[2].ToString();
                            break;
                        }
                    }
                }

                ZBobb.AlphaBlendTextBox tbx_PromName = new ZBobb.AlphaBlendTextBox();
                panel.Controls.Add(tbx_PromName);
                tbx_PromName.Location = new Point(5 + iconWidth + 5, 5);
                tbx_PromName.Size = new Size(nameTxbWidth, nameTxbHeight);
                tbx_PromName.Multiline = true;
                tbx_PromName.Text = promName_Loc == null ? promotionName : promName_Loc;
                tbx_PromName.Tag = promotionName;
                tbx_PromName.BackAlpha = 0;
                tbx_PromName.ForeColor = Color.FromArgb(255, 214, 214, 214);
                tbx_PromName.BackColor = Color.FromArgb(255, 18, 43, 56);
                tbx_PromName.BorderStyle = BorderStyle.None;
                tbx_PromName.Font = new Font(fonts.Families[2], 12);


                ZBobb.AlphaBlendTextBox tbx_PromDesc = new ZBobb.AlphaBlendTextBox();
                panel.Controls.Add(tbx_PromDesc);
                tbx_PromDesc.Location = new Point(10, 5 + nameTxbHeight - 2);
                tbx_PromDesc.Size = new Size(descTxbWidth, descTxbHeight);
                tbx_PromDesc.Multiline = true;
                tbx_PromDesc.Text = promDesc_Loc == null ? promotionDesc : promDesc_Loc;
                tbx_PromDesc.Tag = promotionDesc;
                tbx_PromDesc.BackAlpha = 0;
                tbx_PromDesc.ForeColor = Color.FromArgb(255, 214, 214, 214);
                tbx_PromDesc.BackColor = Color.FromArgb(255, 18, 43, 56);
                tbx_PromDesc.BorderStyle = BorderStyle.None;
                tbx_PromDesc.Font = new Font(fonts.Families[3], 11, FontStyle.Regular, GraphicsUnit.Point, 0);

            }
        }
    }


        
}
