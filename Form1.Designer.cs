namespace Civ6ModdingTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddMainDatabase_Btn = new System.Windows.Forms.Button();
            this.SaveFile_Button = new System.Windows.Forms.Button();
            this.ResetTables_Btn = new System.Windows.Forms.Button();
            this.AddLocalizationFile_Btn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearPromotionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Modifiers = new System.Windows.Forms.TabPage();
            this.AddRequirementArgument_Btn = new System.Windows.Forms.Button();
            this.AddModifierArgument_Btn = new System.Windows.Forms.Button();
            this.CurrentRequirement_Label = new System.Windows.Forms.Label();
            this.CurrentModifier_Label = new System.Windows.Forms.Label();
            this.AddRequirementSetRequirement_Btn = new System.Windows.Forms.Button();
            this.AddRequirementSet_Btn = new System.Windows.Forms.Button();
            this.AddRequirement_Btn = new System.Windows.Forms.Button();
            this.Panel_Table_Requirements = new System.Windows.Forms.Panel();
            this.chbx_Requirement_Triggered1 = new System.Windows.Forms.CheckBox();
            this.IconsGeneral_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Requirement_RequirementType = new System.Windows.Forms.Label();
            this.chbx_Requirement_Persistent1 = new System.Windows.Forms.CheckBox();
            this.lbl_Requirement_Likeliness = new System.Windows.Forms.Label();
            this.chbx_Requirement_Reverse1 = new System.Windows.Forms.CheckBox();
            this.tbx_Requirement_ProgressWeight = new System.Windows.Forms.TextBox();
            this.chbx_Requirement_Inverse1 = new System.Windows.Forms.CheckBox();
            this.lbl_Requirement_Impact = new System.Windows.Forms.Label();
            this.cbx_Requirement_RequirementType = new System.Windows.Forms.ComboBox();
            this.tbx_Requirement_Likeliness = new System.Windows.Forms.TextBox();
            this.lbl_Requirement_ProgressWeight = new System.Windows.Forms.Label();
            this.tbx_Requirement_Impact = new System.Windows.Forms.TextBox();
            this.AddModifier_Btn = new System.Windows.Forms.Button();
            this.Label_Modifiers = new System.Windows.Forms.Label();
            this.Label_ModifierArguments = new System.Windows.Forms.Label();
            this.Label_RequirementArguments = new System.Windows.Forms.Label();
            this.Label_Requirements = new System.Windows.Forms.Label();
            this.Label_RequirementSetRequirements = new System.Windows.Forms.Label();
            this.Label_RequirementSets = new System.Windows.Forms.Label();
            this.Panel_Table_Modifiers = new System.Windows.Forms.Panel();
            this.chbx_Modifier_NewOnly = new System.Windows.Forms.CheckBox();
            this.lbl_Modifier_Subject = new System.Windows.Forms.Label();
            this.chbx_Modifier_RunOnce = new System.Windows.Forms.CheckBox();
            this.lbl_Modifier_Owner = new System.Windows.Forms.Label();
            this.chbx_Modifier_Repeatable = new System.Windows.Forms.CheckBox();
            this.lbl_Modifier_StackLimit = new System.Windows.Forms.Label();
            this.lbl_Modifier_RequirementSetID = new System.Windows.Forms.Label();
            this.lbl_Modifier_ModifierType = new System.Windows.Forms.Label();
            this.cbx_Modifier_ModifierType = new System.Windows.Forms.ComboBox();
            this.tbx_Modifier_SubjectStackLimit = new System.Windows.Forms.TextBox();
            this.cbx_Modifier_SubjectRequirementSetID = new System.Windows.Forms.ComboBox();
            this.tbx_Modifier_OwnerStackLimit = new System.Windows.Forms.TextBox();
            this.cbx_Modifier_OwnerRequirementSetID = new System.Windows.Forms.ComboBox();
            this.chbx_Modifier_Permanent = new System.Windows.Forms.CheckBox();
            this.GridView_RequirementArguments = new System.Windows.Forms.DataGridView();
            this.GV_RequirementArguments_Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_RequirementArguments_Col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_RequirementArguments_Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_RequirementArguments_Col_Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_RequirementArguments_Col_SecondExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_RequirementSetRequirements = new System.Windows.Forms.DataGridView();
            this.GV_RequirementSetRequirements_Col_RequirementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_RequirementSets = new System.Windows.Forms.DataGridView();
            this.GV_RequirementSets_Col_RequirementSetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_RequirementSets_Col_RequirementSetType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GridView_Requirements = new System.Windows.Forms.DataGridView();
            this.GV_Requirements_Col_RequirementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_Requirements_Col_RequirementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_ModifierArguments = new System.Windows.Forms.DataGridView();
            this.GV_ModifierArguments_Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ModifierArguments_Col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ModifierArguments_Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ModifierArguments_Col_Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ModifierArguments_Col_SecondExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_Modifiers = new System.Windows.Forms.DataGridView();
            this.GV_Modifiers_Col_ModifierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_Modifiers_Col_ModifierType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_UnitPromotions = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPromotionClass_Label = new System.Windows.Forms.Label();
            this.AddUnitPromotion_Btn = new System.Windows.Forms.Button();
            this.AddUnitPromotionClasse_Btn = new System.Windows.Forms.Button();
            this.GridView_UnitPromotionPrereqs = new System.Windows.Forms.DataGridView();
            this.GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridView_UnitPromotionClasses = new System.Windows.Forms.DataGridView();
            this.GV_UnitPromotionClasses_Col_PromotionClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotionClasses_Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_UnitPromotions = new System.Windows.Forms.DataGridView();
            this.GV_UnitPromotions_Col_UnitPromotionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotions_Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotions_Col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotions_Col_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotions_Col_Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotions_Col_PromotionClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnitPromotions_Col_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_PromotionClassPromotions = new System.Windows.Forms.Panel();
            this.tab_Units = new System.Windows.Forms.TabPage();
            this.GridView_Unit_BuildingPrereqs = new System.Windows.Forms.DataGridView();
            this.Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridview_Unit_BuildingPrereqs_Col_NumSupported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbx_ShowAbilitiesTags = new System.Windows.Forms.CheckBox();
            this.Panel_Table_UnitAbilities = new System.Windows.Forms.Panel();
            this.chbx_Abilitie_Permanent = new System.Windows.Forms.CheckBox();
            this.chbx_Abilitie_ShowFloatTextWhenEarned = new System.Windows.Forms.CheckBox();
            this.chbx_Abilitie_Inactive = new System.Windows.Forms.CheckBox();
            this.tbx_Loc_Abilitie_Name = new ZBobb.AlphaBlendTextBox();
            this.tbx_Loc_Abilitie_Description = new System.Windows.Forms.RichTextBox();
            this.Label_UnitAbilities = new System.Windows.Forms.Label();
            this.AddAbilityTag_Btn = new System.Windows.Forms.Button();
            this.GridView_AbilityTags = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUnitTag_Btn = new System.Windows.Forms.Button();
            this.AddUnitAiInfo_Btn = new System.Windows.Forms.Button();
            this.AddUnitUpgrade_Btn = new System.Windows.Forms.Button();
            this.AddUnitAbilitie_Btn = new System.Windows.Forms.Button();
            this.AddUnitReplace_Btn = new System.Windows.Forms.Button();
            this.AddUnit_Btn = new System.Windows.Forms.Button();
            this.AddUnit_BuildingPrereq_Btn = new System.Windows.Forms.Button();
            this.GridView_UnitAbilities = new System.Windows.Forms.DataGridView();
            this.Gridview_UnitAbilities_Col_UnitAbilityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridview_UnitAbilities_Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridview_UnitAbilities_Col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridview_UnitAbilities_Col_Inactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridview_UnitAbilities_Col_Permanent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_UnitTags = new System.Windows.Forms.DataGridView();
            this.Gridview_TypeTags_Col_Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_UnitAiInfos = new System.Windows.Forms.DataGridView();
            this.Gridview_UnitAiInfos_Col_AiType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_Units = new System.Windows.Forms.DataGridView();
            this.GridView_UnitUpgrades = new System.Windows.Forms.DataGridView();
            this.Gridview_UnitUpgrades_Col_UpgradeUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Table_Units = new System.Windows.Forms.Panel();
            this.tbx_Loc_Unit_Name = new ZBobb.AlphaBlendTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_Unit_Maintenance = new System.Windows.Forms.PictureBox();
            this.cbx_Unit_XP2_ResourceMaintenanceType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbx_Unit_Maintenance = new System.Windows.Forms.TextBox();
            this.tbx_Unit_XP2_ResourceMaintenanceAmount = new System.Windows.Forms.TextBox();
            this.pic_Unit_XP2_ResourceMaintenanceType = new System.Windows.Forms.PictureBox();
            this.tbx_Loc_Unit_Description = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chbx_Unit_Spy = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_TeamVisibility = new System.Windows.Forms.CheckBox();
            this.pic_Unit_TraitType = new System.Windows.Forms.PictureBox();
            this.cbx_Unit_PseudoYieldType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_NumRandomChoices = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_TraitType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbx_Unit_NumRandomChoices = new System.Windows.Forms.TextBox();
            this.cbx_Unit_AdvisorType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_LeaderType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.chbx_Unit_FoundCity = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_MakeTradeRoute = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_ExtractsArtifacts = new System.Windows.Forms.CheckBox();
            this.tbx_Unit_DisasterCharges = new System.Windows.Forms.TextBox();
            this.chbx_Unit_ImmediatelyName = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_XP2_MajorCivOnly = new System.Windows.Forms.CheckBox();
            this.pic_Unit_LeaderType = new System.Windows.Forms.PictureBox();
            this.pic_Unit_PseudoYieldType = new System.Windows.Forms.PictureBox();
            this.chbx_Unit_Stackable = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_AllowBarbarians = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_XP2_CanCauseDisasters = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_IgnoreMoves = new System.Windows.Forms.CheckBox();
            this.tbx_Unit_BuildCharges = new System.Windows.Forms.TextBox();
            this.tbx_Unit_XP2_TourismBomb = new System.Windows.Forms.TextBox();
            this.pic_Unit_AdvisorType = new System.Windows.Forms.PictureBox();
            this.chbx_Unit_XP2_CanSacrificeUnits = new System.Windows.Forms.CheckBox();
            this.pic_Unit_BuildCharges = new System.Windows.Forms.PictureBox();
            this.chbx_Unit_XP2_TourismBombPossible = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbx_Unit_MandatoryObsoleteCivic = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_MandatoryObsoleteTech = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_MandatoryObsoleteCivic = new System.Windows.Forms.PictureBox();
            this.pic_Unit_MandatoryObsoleteTech = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbx_Unit_ObsoleteCivic = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_ObsoleteTech = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_ObsoleteTech = new System.Windows.Forms.PictureBox();
            this.pic_Unit_ObsoleteCivic = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbx_Unit_PrereqDistrict = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_PrereqCivic = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_PrereqTech = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_PrereqTech = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_PrereqPopulation = new System.Windows.Forms.TextBox();
            this.pic_Unit_PrereqCivic = new System.Windows.Forms.PictureBox();
            this.pic_Unit_PrereqDistrict = new System.Windows.Forms.PictureBox();
            this.pic_Unit_PrereqPopulation = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pic_Unit_CostProgressionModel = new System.Windows.Forms.PictureBox();
            this.cbx_Unit_PurchaseYield = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbx_Unit_CostProgressionParam1 = new System.Windows.Forms.TextBox();
            this.tbx_Unit_CostProgressionModel = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_StrategicResource = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_PurchaseYield = new System.Windows.Forms.PictureBox();
            this.pic_Unit_StrategicResource = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_XP2_ResourceCost = new System.Windows.Forms.TextBox();
            this.pic_Unit_Cost = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_Cost = new System.Windows.Forms.TextBox();
            this.tbx_Unit_PopulationCost = new System.Windows.Forms.TextBox();
            this.chbx_Unit_MustPurchase = new System.Windows.Forms.CheckBox();
            this.pic_Unit_PopulationCost = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx_Unit_PromotionClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_InitialLevel = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_Flavor = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbx_Unit_FormationClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_AirSlots = new System.Windows.Forms.PictureBox();
            this.pic_Unit_FormationClass = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_InitialLevel = new System.Windows.Forms.TextBox();
            this.cbx_Unit_Domain = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pic_Unit_Domain = new System.Windows.Forms.PictureBox();
            this.chbx_Unit_CanCapture = new System.Windows.Forms.CheckBox();
            this.pic_Unit_PromotionClass = new System.Windows.Forms.PictureBox();
            this.chbx_Unit_CanRetreatWhenCaptured = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_XP2_CanEarnExperience = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_XP2_CanFormMilitaryFormation = new System.Windows.Forms.CheckBox();
            this.tbx_Unit_AirSlots = new System.Windows.Forms.TextBox();
            this.chbx_Unit_CanTargetAir = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_ZoneOfControl = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_CanTrain = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_CanEarnExperience = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_WMDCapable = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_UseMaxMeleeTrainedStrength = new System.Windows.Forms.CheckBox();
            this.pic_Unit_Combat = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_Combat = new System.Windows.Forms.TextBox();
            this.tbx_Unit_RangedCombat = new System.Windows.Forms.TextBox();
            this.pic_Unit_RangedCombat = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_BaseMoves = new System.Windows.Forms.TextBox();
            this.pic_Unit_BaseMoves = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_Range = new System.Windows.Forms.TextBox();
            this.pic_Unit_Range = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_BaseSightRange = new System.Windows.Forms.TextBox();
            this.pic_Unit_BaseSightRange = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_Bombard = new System.Windows.Forms.TextBox();
            this.pic_Unit_Bombard = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_Unit_ReligiousStrength = new System.Windows.Forms.PictureBox();
            this.tbx_Unit_ReligiousStrength = new System.Windows.Forms.TextBox();
            this.chbx_Unit_FoundReligion = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_EvangelizeBelief = new System.Windows.Forms.CheckBox();
            this.tbx_Unit_ReligionEvictPercent = new System.Windows.Forms.TextBox();
            this.chbx_Unit_LaunchInquisition = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_RequiresInquisition = new System.Windows.Forms.CheckBox();
            this.tbx_Unit_SpreadCharges = new System.Windows.Forms.TextBox();
            this.chbx_Unit_TrackReligion = new System.Windows.Forms.CheckBox();
            this.chbx_Unit_EnabledByReligion = new System.Windows.Forms.CheckBox();
            this.tbx_Unit_ReligiousHealCharges = new System.Windows.Forms.TextBox();
            this.pic_Unit_SpreadCharges = new System.Windows.Forms.PictureBox();
            this.pic_Unit_ReligionEvictPercent = new System.Windows.Forms.PictureBox();
            this.pic_Unit_ReligiousHealCharges = new System.Windows.Forms.PictureBox();
            this.CurrentUnit_Label = new System.Windows.Forms.Label();
            this.GridView_UnitReplaces = new System.Windows.Forms.DataGridView();
            this.Gridview_UnitReplaces_Col_ReplacesUnitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chbx_AddNewTexts = new System.Windows.Forms.CheckBox();
            this.SaveLocalizedText_Button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tab_Modifiers.SuspendLayout();
            this.Panel_Table_Requirements.SuspendLayout();
            this.Panel_Table_Modifiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_RequirementArguments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_RequirementSetRequirements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_RequirementSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Requirements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ModifierArguments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Modifiers)).BeginInit();
            this.tab_UnitPromotions.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitPromotionPrereqs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitPromotionClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitPromotions)).BeginInit();
            this.tab_Units.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Unit_BuildingPrereqs)).BeginInit();
            this.Panel_Table_UnitAbilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_AbilityTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitAbilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitAiInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Units)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitUpgrades)).BeginInit();
            this.Panel_Table_Units.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Maintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_XP2_ResourceMaintenanceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_XP2_ResourceMaintenanceType)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_TraitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PseudoYieldType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_NumRandomChoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Unit_TraitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_AdvisorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_LeaderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_LeaderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PseudoYieldType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_AdvisorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_BuildCharges)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_MandatoryObsoleteCivic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_MandatoryObsoleteTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_MandatoryObsoleteCivic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_MandatoryObsoleteTech)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_ObsoleteCivic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_ObsoleteTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ObsoleteTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ObsoleteCivic)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PrereqDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PrereqCivic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PrereqTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqCivic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqPopulation)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_CostProgressionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PurchaseYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Unit_CostProgressionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_StrategicResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PurchaseYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_StrategicResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PopulationCost)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PromotionClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_InitialLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Unit_Flavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_FormationClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_AirSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_FormationClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_Domain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Domain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PromotionClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Combat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_RangedCombat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_BaseMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_BaseSightRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Bombard)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ReligiousStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_SpreadCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ReligionEvictPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ReligiousHealCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitReplaces)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMainDatabase_Btn
            // 
            this.AddMainDatabase_Btn.Location = new System.Drawing.Point(1663, 66);
            this.AddMainDatabase_Btn.Name = "AddMainDatabase_Btn";
            this.AddMainDatabase_Btn.Size = new System.Drawing.Size(120, 23);
            this.AddMainDatabase_Btn.TabIndex = 0;
            this.AddMainDatabase_Btn.Text = "Add Main Database";
            this.AddMainDatabase_Btn.UseVisualStyleBackColor = true;
            this.AddMainDatabase_Btn.Click += new System.EventHandler(this.AddMainDatabase_Btn_Click);
            // 
            // SaveFile_Button
            // 
            this.SaveFile_Button.Location = new System.Drawing.Point(1663, 150);
            this.SaveFile_Button.Name = "SaveFile_Button";
            this.SaveFile_Button.Size = new System.Drawing.Size(120, 23);
            this.SaveFile_Button.TabIndex = 8;
            this.SaveFile_Button.Text = "Save File";
            this.SaveFile_Button.UseVisualStyleBackColor = true;
            this.SaveFile_Button.Click += new System.EventHandler(this.SaveFile_Button_Click);
            // 
            // ResetTables_Btn
            // 
            this.ResetTables_Btn.Location = new System.Drawing.Point(1663, 121);
            this.ResetTables_Btn.Name = "ResetTables_Btn";
            this.ResetTables_Btn.Size = new System.Drawing.Size(120, 23);
            this.ResetTables_Btn.TabIndex = 12;
            this.ResetTables_Btn.Text = "Reset Tables";
            this.ResetTables_Btn.UseVisualStyleBackColor = true;
            this.ResetTables_Btn.Click += new System.EventHandler(this.ResetTables_Btn_Click);
            // 
            // AddLocalizationFile_Btn
            // 
            this.AddLocalizationFile_Btn.Location = new System.Drawing.Point(1663, 32);
            this.AddLocalizationFile_Btn.Name = "AddLocalizationFile_Btn";
            this.AddLocalizationFile_Btn.Size = new System.Drawing.Size(120, 23);
            this.AddLocalizationFile_Btn.TabIndex = 18;
            this.AddLocalizationFile_Btn.Text = "Add Localization File";
            this.AddLocalizationFile_Btn.UseVisualStyleBackColor = true;
            this.AddLocalizationFile_Btn.Click += new System.EventHandler(this.AddLocalizationFile_Btn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearPromotionsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 26);
            // 
            // clearPromotionsToolStripMenuItem
            // 
            this.clearPromotionsToolStripMenuItem.Name = "clearPromotionsToolStripMenuItem";
            this.clearPromotionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearPromotionsToolStripMenuItem.Text = "Clear Promotions";
            // 
            // tab_Modifiers
            // 
            this.tab_Modifiers.Controls.Add(this.AddRequirementArgument_Btn);
            this.tab_Modifiers.Controls.Add(this.AddModifierArgument_Btn);
            this.tab_Modifiers.Controls.Add(this.CurrentRequirement_Label);
            this.tab_Modifiers.Controls.Add(this.CurrentModifier_Label);
            this.tab_Modifiers.Controls.Add(this.AddRequirementSetRequirement_Btn);
            this.tab_Modifiers.Controls.Add(this.AddRequirementSet_Btn);
            this.tab_Modifiers.Controls.Add(this.AddRequirement_Btn);
            this.tab_Modifiers.Controls.Add(this.Panel_Table_Requirements);
            this.tab_Modifiers.Controls.Add(this.AddModifier_Btn);
            this.tab_Modifiers.Controls.Add(this.Label_Modifiers);
            this.tab_Modifiers.Controls.Add(this.Label_ModifierArguments);
            this.tab_Modifiers.Controls.Add(this.Label_RequirementArguments);
            this.tab_Modifiers.Controls.Add(this.Label_Requirements);
            this.tab_Modifiers.Controls.Add(this.Label_RequirementSetRequirements);
            this.tab_Modifiers.Controls.Add(this.Label_RequirementSets);
            this.tab_Modifiers.Controls.Add(this.Panel_Table_Modifiers);
            this.tab_Modifiers.Controls.Add(this.GridView_RequirementArguments);
            this.tab_Modifiers.Controls.Add(this.GridView_RequirementSetRequirements);
            this.tab_Modifiers.Controls.Add(this.GridView_RequirementSets);
            this.tab_Modifiers.Controls.Add(this.GridView_Requirements);
            this.tab_Modifiers.Controls.Add(this.GridView_ModifierArguments);
            this.tab_Modifiers.Controls.Add(this.GridView_Modifiers);
            this.tab_Modifiers.Location = new System.Drawing.Point(4, 22);
            this.tab_Modifiers.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Modifiers.Name = "tab_Modifiers";
            this.tab_Modifiers.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Modifiers.Size = new System.Drawing.Size(1643, 996);
            this.tab_Modifiers.TabIndex = 2;
            this.tab_Modifiers.Text = "Modifiers";
            this.tab_Modifiers.UseVisualStyleBackColor = true;
            // 
            // AddRequirementArgument_Btn
            // 
            this.AddRequirementArgument_Btn.Location = new System.Drawing.Point(1107, 347);
            this.AddRequirementArgument_Btn.Name = "AddRequirementArgument_Btn";
            this.AddRequirementArgument_Btn.Size = new System.Drawing.Size(150, 23);
            this.AddRequirementArgument_Btn.TabIndex = 49;
            this.AddRequirementArgument_Btn.Text = "Add Requirement Argument";
            this.AddRequirementArgument_Btn.UseVisualStyleBackColor = true;
            this.AddRequirementArgument_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // AddModifierArgument_Btn
            // 
            this.AddModifierArgument_Btn.Location = new System.Drawing.Point(1107, 172);
            this.AddModifierArgument_Btn.Name = "AddModifierArgument_Btn";
            this.AddModifierArgument_Btn.Size = new System.Drawing.Size(150, 23);
            this.AddModifierArgument_Btn.TabIndex = 48;
            this.AddModifierArgument_Btn.Text = "Add Modifier Requirement:";
            this.AddModifierArgument_Btn.UseVisualStyleBackColor = true;
            this.AddModifierArgument_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // CurrentRequirement_Label
            // 
            this.CurrentRequirement_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRequirement_Label.ForeColor = System.Drawing.Color.Navy;
            this.CurrentRequirement_Label.Location = new System.Drawing.Point(688, 201);
            this.CurrentRequirement_Label.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentRequirement_Label.Name = "CurrentRequirement_Label";
            this.CurrentRequirement_Label.Size = new System.Drawing.Size(414, 27);
            this.CurrentRequirement_Label.TabIndex = 47;
            this.CurrentRequirement_Label.Text = "Current Requirement";
            this.CurrentRequirement_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CurrentModifier_Label
            // 
            this.CurrentModifier_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentModifier_Label.ForeColor = System.Drawing.Color.Navy;
            this.CurrentModifier_Label.Location = new System.Drawing.Point(692, 0);
            this.CurrentModifier_Label.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentModifier_Label.Name = "CurrentModifier_Label";
            this.CurrentModifier_Label.Size = new System.Drawing.Size(410, 27);
            this.CurrentModifier_Label.TabIndex = 46;
            this.CurrentModifier_Label.Text = "Current Modifier";
            this.CurrentModifier_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddRequirementSetRequirement_Btn
            // 
            this.AddRequirementSetRequirement_Btn.Location = new System.Drawing.Point(344, 346);
            this.AddRequirementSetRequirement_Btn.Name = "AddRequirementSetRequirement_Btn";
            this.AddRequirementSetRequirement_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddRequirementSetRequirement_Btn.TabIndex = 45;
            this.AddRequirementSetRequirement_Btn.Text = "Add Requirement to Set";
            this.AddRequirementSetRequirement_Btn.UseVisualStyleBackColor = true;
            this.AddRequirementSetRequirement_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // AddRequirementSet_Btn
            // 
            this.AddRequirementSet_Btn.Location = new System.Drawing.Point(99, 347);
            this.AddRequirementSet_Btn.Name = "AddRequirementSet_Btn";
            this.AddRequirementSet_Btn.Size = new System.Drawing.Size(142, 23);
            this.AddRequirementSet_Btn.TabIndex = 41;
            this.AddRequirementSet_Btn.Text = "Add New Requirement Set";
            this.AddRequirementSet_Btn.UseVisualStyleBackColor = true;
            this.AddRequirementSet_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // AddRequirement_Btn
            // 
            this.AddRequirement_Btn.Location = new System.Drawing.Point(344, 757);
            this.AddRequirement_Btn.Name = "AddRequirement_Btn";
            this.AddRequirement_Btn.Size = new System.Drawing.Size(131, 23);
            this.AddRequirement_Btn.TabIndex = 40;
            this.AddRequirement_Btn.Text = "Add New Requirement";
            this.AddRequirement_Btn.UseVisualStyleBackColor = true;
            this.AddRequirement_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // Panel_Table_Requirements
            // 
            this.Panel_Table_Requirements.Controls.Add(this.chbx_Requirement_Triggered1);
            this.Panel_Table_Requirements.Controls.Add(this.lbl_Requirement_RequirementType);
            this.Panel_Table_Requirements.Controls.Add(this.chbx_Requirement_Persistent1);
            this.Panel_Table_Requirements.Controls.Add(this.lbl_Requirement_Likeliness);
            this.Panel_Table_Requirements.Controls.Add(this.chbx_Requirement_Reverse1);
            this.Panel_Table_Requirements.Controls.Add(this.tbx_Requirement_ProgressWeight);
            this.Panel_Table_Requirements.Controls.Add(this.chbx_Requirement_Inverse1);
            this.Panel_Table_Requirements.Controls.Add(this.lbl_Requirement_Impact);
            this.Panel_Table_Requirements.Controls.Add(this.cbx_Requirement_RequirementType);
            this.Panel_Table_Requirements.Controls.Add(this.tbx_Requirement_Likeliness);
            this.Panel_Table_Requirements.Controls.Add(this.lbl_Requirement_ProgressWeight);
            this.Panel_Table_Requirements.Controls.Add(this.tbx_Requirement_Impact);
            this.Panel_Table_Requirements.Location = new System.Drawing.Point(481, 231);
            this.Panel_Table_Requirements.Name = "Panel_Table_Requirements";
            this.Panel_Table_Requirements.Size = new System.Drawing.Size(621, 110);
            this.Panel_Table_Requirements.TabIndex = 32;
            // 
            // chbx_Requirement_Triggered1
            // 
            this.chbx_Requirement_Triggered1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Requirement_Triggered1.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Triggered1.FlatAppearance.BorderSize = 0;
            this.chbx_Requirement_Triggered1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Triggered1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Requirement_Triggered1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Requirement_Triggered1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Requirement_Triggered1.ImageIndex = 1;
            this.chbx_Requirement_Triggered1.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Requirement_Triggered1.Location = new System.Drawing.Point(1, 81);
            this.chbx_Requirement_Triggered1.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Requirement_Triggered1.Name = "chbx_Requirement_Triggered1";
            this.chbx_Requirement_Triggered1.Size = new System.Drawing.Size(104, 27);
            this.chbx_Requirement_Triggered1.TabIndex = 55;
            this.chbx_Requirement_Triggered1.Text = "Triggered";
            this.chbx_Requirement_Triggered1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Requirement_Triggered1.UseVisualStyleBackColor = true;
            this.chbx_Requirement_Triggered1.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // IconsGeneral_ImageList
            // 
            this.IconsGeneral_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsGeneral_ImageList.ImageStream")));
            this.IconsGeneral_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsGeneral_ImageList.Images.SetKeyName(0, "correction.png");
            this.IconsGeneral_ImageList.Images.SetKeyName(1, "remove.png");
            // 
            // lbl_Requirement_RequirementType
            // 
            this.lbl_Requirement_RequirementType.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Requirement_RequirementType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Requirement_RequirementType.Location = new System.Drawing.Point(112, 6);
            this.lbl_Requirement_RequirementType.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Requirement_RequirementType.Name = "lbl_Requirement_RequirementType";
            this.lbl_Requirement_RequirementType.Size = new System.Drawing.Size(439, 21);
            this.lbl_Requirement_RequirementType.TabIndex = 43;
            this.lbl_Requirement_RequirementType.Text = "RequirementType";
            this.lbl_Requirement_RequirementType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chbx_Requirement_Persistent1
            // 
            this.chbx_Requirement_Persistent1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Requirement_Persistent1.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Persistent1.FlatAppearance.BorderSize = 0;
            this.chbx_Requirement_Persistent1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Persistent1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Requirement_Persistent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Requirement_Persistent1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Requirement_Persistent1.ImageIndex = 1;
            this.chbx_Requirement_Persistent1.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Requirement_Persistent1.Location = new System.Drawing.Point(1, 54);
            this.chbx_Requirement_Persistent1.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Requirement_Persistent1.Name = "chbx_Requirement_Persistent1";
            this.chbx_Requirement_Persistent1.Size = new System.Drawing.Size(104, 27);
            this.chbx_Requirement_Persistent1.TabIndex = 54;
            this.chbx_Requirement_Persistent1.Text = "Persistent";
            this.chbx_Requirement_Persistent1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Requirement_Persistent1.UseVisualStyleBackColor = true;
            this.chbx_Requirement_Persistent1.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // lbl_Requirement_Likeliness
            // 
            this.lbl_Requirement_Likeliness.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Requirement_Likeliness.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Requirement_Likeliness.Location = new System.Drawing.Point(107, 57);
            this.lbl_Requirement_Likeliness.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Requirement_Likeliness.Name = "lbl_Requirement_Likeliness";
            this.lbl_Requirement_Likeliness.Size = new System.Drawing.Size(115, 21);
            this.lbl_Requirement_Likeliness.TabIndex = 42;
            this.lbl_Requirement_Likeliness.Text = "Likeliness";
            this.lbl_Requirement_Likeliness.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chbx_Requirement_Reverse1
            // 
            this.chbx_Requirement_Reverse1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Requirement_Reverse1.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Reverse1.FlatAppearance.BorderSize = 0;
            this.chbx_Requirement_Reverse1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Reverse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Requirement_Reverse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Requirement_Reverse1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Requirement_Reverse1.ImageIndex = 1;
            this.chbx_Requirement_Reverse1.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Requirement_Reverse1.Location = new System.Drawing.Point(1, 27);
            this.chbx_Requirement_Reverse1.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Requirement_Reverse1.Name = "chbx_Requirement_Reverse1";
            this.chbx_Requirement_Reverse1.Size = new System.Drawing.Size(104, 27);
            this.chbx_Requirement_Reverse1.TabIndex = 53;
            this.chbx_Requirement_Reverse1.Text = "Reverse";
            this.chbx_Requirement_Reverse1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Requirement_Reverse1.UseVisualStyleBackColor = true;
            this.chbx_Requirement_Reverse1.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // tbx_Requirement_ProgressWeight
            // 
            this.tbx_Requirement_ProgressWeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbx_Requirement_ProgressWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Requirement_ProgressWeight.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Requirement_ProgressWeight.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Requirement_ProgressWeight.Location = new System.Drawing.Point(462, 80);
            this.tbx_Requirement_ProgressWeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Requirement_ProgressWeight.Name = "tbx_Requirement_ProgressWeight";
            this.tbx_Requirement_ProgressWeight.Size = new System.Drawing.Size(60, 25);
            this.tbx_Requirement_ProgressWeight.TabIndex = 32;
            this.tbx_Requirement_ProgressWeight.WordWrap = false;
            // 
            // chbx_Requirement_Inverse1
            // 
            this.chbx_Requirement_Inverse1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Requirement_Inverse1.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Inverse1.FlatAppearance.BorderSize = 0;
            this.chbx_Requirement_Inverse1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Requirement_Inverse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Requirement_Inverse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Requirement_Inverse1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Requirement_Inverse1.ImageIndex = 1;
            this.chbx_Requirement_Inverse1.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Requirement_Inverse1.Location = new System.Drawing.Point(1, 0);
            this.chbx_Requirement_Inverse1.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Requirement_Inverse1.Name = "chbx_Requirement_Inverse1";
            this.chbx_Requirement_Inverse1.Size = new System.Drawing.Size(104, 27);
            this.chbx_Requirement_Inverse1.TabIndex = 52;
            this.chbx_Requirement_Inverse1.Text = "Inverse";
            this.chbx_Requirement_Inverse1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Requirement_Inverse1.UseVisualStyleBackColor = true;
            this.chbx_Requirement_Inverse1.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // lbl_Requirement_Impact
            // 
            this.lbl_Requirement_Impact.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Requirement_Impact.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Requirement_Impact.Location = new System.Drawing.Point(271, 57);
            this.lbl_Requirement_Impact.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Requirement_Impact.Name = "lbl_Requirement_Impact";
            this.lbl_Requirement_Impact.Size = new System.Drawing.Size(115, 21);
            this.lbl_Requirement_Impact.TabIndex = 41;
            this.lbl_Requirement_Impact.Text = "Impact";
            this.lbl_Requirement_Impact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbx_Requirement_RequirementType
            // 
            this.cbx_Requirement_RequirementType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Requirement_RequirementType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Requirement_RequirementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Requirement_RequirementType.FormattingEnabled = true;
            this.cbx_Requirement_RequirementType.Location = new System.Drawing.Point(111, 30);
            this.cbx_Requirement_RequirementType.Name = "cbx_Requirement_RequirementType";
            this.cbx_Requirement_RequirementType.Size = new System.Drawing.Size(453, 24);
            this.cbx_Requirement_RequirementType.Sorted = true;
            this.cbx_Requirement_RequirementType.TabIndex = 31;
            this.cbx_Requirement_RequirementType.Click += new System.EventHandler(this.AllComboBoxes_Click);
            // 
            // tbx_Requirement_Likeliness
            // 
            this.tbx_Requirement_Likeliness.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbx_Requirement_Likeliness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Requirement_Likeliness.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Requirement_Likeliness.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Requirement_Likeliness.Location = new System.Drawing.Point(134, 80);
            this.tbx_Requirement_Likeliness.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Requirement_Likeliness.Name = "tbx_Requirement_Likeliness";
            this.tbx_Requirement_Likeliness.Size = new System.Drawing.Size(60, 25);
            this.tbx_Requirement_Likeliness.TabIndex = 24;
            this.tbx_Requirement_Likeliness.WordWrap = false;
            // 
            // lbl_Requirement_ProgressWeight
            // 
            this.lbl_Requirement_ProgressWeight.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Requirement_ProgressWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Requirement_ProgressWeight.Location = new System.Drawing.Point(436, 57);
            this.lbl_Requirement_ProgressWeight.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Requirement_ProgressWeight.Name = "lbl_Requirement_ProgressWeight";
            this.lbl_Requirement_ProgressWeight.Size = new System.Drawing.Size(115, 21);
            this.lbl_Requirement_ProgressWeight.TabIndex = 40;
            this.lbl_Requirement_ProgressWeight.Text = "ProgressWeight";
            this.lbl_Requirement_ProgressWeight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbx_Requirement_Impact
            // 
            this.tbx_Requirement_Impact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbx_Requirement_Impact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Requirement_Impact.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Requirement_Impact.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Requirement_Impact.Location = new System.Drawing.Point(300, 80);
            this.tbx_Requirement_Impact.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Requirement_Impact.Name = "tbx_Requirement_Impact";
            this.tbx_Requirement_Impact.Size = new System.Drawing.Size(60, 25);
            this.tbx_Requirement_Impact.TabIndex = 23;
            this.tbx_Requirement_Impact.WordWrap = false;
            // 
            // AddModifier_Btn
            // 
            this.AddModifier_Btn.Location = new System.Drawing.Point(349, 172);
            this.AddModifier_Btn.Name = "AddModifier_Btn";
            this.AddModifier_Btn.Size = new System.Drawing.Size(120, 23);
            this.AddModifier_Btn.TabIndex = 39;
            this.AddModifier_Btn.Text = "Add New Modifier";
            this.AddModifier_Btn.UseVisualStyleBackColor = true;
            this.AddModifier_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // Label_Modifiers
            // 
            this.Label_Modifiers.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Modifiers.Location = new System.Drawing.Point(477, 0);
            this.Label_Modifiers.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Modifiers.Name = "Label_Modifiers";
            this.Label_Modifiers.Size = new System.Drawing.Size(211, 27);
            this.Label_Modifiers.TabIndex = 38;
            this.Label_Modifiers.Text = "Current Modifier:";
            this.Label_Modifiers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_ModifierArguments
            // 
            this.Label_ModifierArguments.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ModifierArguments.Location = new System.Drawing.Point(1108, 0);
            this.Label_ModifierArguments.Margin = new System.Windows.Forms.Padding(0);
            this.Label_ModifierArguments.Name = "Label_ModifierArguments";
            this.Label_ModifierArguments.Size = new System.Drawing.Size(304, 27);
            this.Label_ModifierArguments.TabIndex = 37;
            this.Label_ModifierArguments.Text = "ModifierArguments";
            this.Label_ModifierArguments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_RequirementArguments
            // 
            this.Label_RequirementArguments.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RequirementArguments.Location = new System.Drawing.Point(1107, 201);
            this.Label_RequirementArguments.Margin = new System.Windows.Forms.Padding(0);
            this.Label_RequirementArguments.Name = "Label_RequirementArguments";
            this.Label_RequirementArguments.Size = new System.Drawing.Size(301, 27);
            this.Label_RequirementArguments.TabIndex = 36;
            this.Label_RequirementArguments.Text = "RequirementArguments";
            this.Label_RequirementArguments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_Requirements
            // 
            this.Label_Requirements.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Requirements.Location = new System.Drawing.Point(481, 201);
            this.Label_Requirements.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Requirements.Name = "Label_Requirements";
            this.Label_Requirements.Size = new System.Drawing.Size(207, 27);
            this.Label_Requirements.TabIndex = 35;
            this.Label_Requirements.Text = "Current Requirement:";
            this.Label_Requirements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_RequirementSetRequirements
            // 
            this.Label_RequirementSetRequirements.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RequirementSetRequirements.Location = new System.Drawing.Point(249, 201);
            this.Label_RequirementSetRequirements.Margin = new System.Windows.Forms.Padding(0);
            this.Label_RequirementSetRequirements.Name = "Label_RequirementSetRequirements";
            this.Label_RequirementSetRequirements.Size = new System.Drawing.Size(225, 27);
            this.Label_RequirementSetRequirements.TabIndex = 34;
            this.Label_RequirementSetRequirements.Text = "RequirementSetRequirements";
            this.Label_RequirementSetRequirements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_RequirementSets
            // 
            this.Label_RequirementSets.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RequirementSets.Location = new System.Drawing.Point(2, 201);
            this.Label_RequirementSets.Margin = new System.Windows.Forms.Padding(0);
            this.Label_RequirementSets.Name = "Label_RequirementSets";
            this.Label_RequirementSets.Size = new System.Drawing.Size(239, 27);
            this.Label_RequirementSets.TabIndex = 33;
            this.Label_RequirementSets.Text = "RequirementSets";
            this.Label_RequirementSets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Panel_Table_Modifiers
            // 
            this.Panel_Table_Modifiers.Controls.Add(this.chbx_Modifier_NewOnly);
            this.Panel_Table_Modifiers.Controls.Add(this.lbl_Modifier_Subject);
            this.Panel_Table_Modifiers.Controls.Add(this.chbx_Modifier_RunOnce);
            this.Panel_Table_Modifiers.Controls.Add(this.lbl_Modifier_Owner);
            this.Panel_Table_Modifiers.Controls.Add(this.chbx_Modifier_Repeatable);
            this.Panel_Table_Modifiers.Controls.Add(this.lbl_Modifier_StackLimit);
            this.Panel_Table_Modifiers.Controls.Add(this.lbl_Modifier_RequirementSetID);
            this.Panel_Table_Modifiers.Controls.Add(this.lbl_Modifier_ModifierType);
            this.Panel_Table_Modifiers.Controls.Add(this.cbx_Modifier_ModifierType);
            this.Panel_Table_Modifiers.Controls.Add(this.tbx_Modifier_SubjectStackLimit);
            this.Panel_Table_Modifiers.Controls.Add(this.cbx_Modifier_SubjectRequirementSetID);
            this.Panel_Table_Modifiers.Controls.Add(this.tbx_Modifier_OwnerStackLimit);
            this.Panel_Table_Modifiers.Controls.Add(this.cbx_Modifier_OwnerRequirementSetID);
            this.Panel_Table_Modifiers.Controls.Add(this.chbx_Modifier_Permanent);
            this.Panel_Table_Modifiers.Location = new System.Drawing.Point(482, 30);
            this.Panel_Table_Modifiers.Name = "Panel_Table_Modifiers";
            this.Panel_Table_Modifiers.Size = new System.Drawing.Size(620, 136);
            this.Panel_Table_Modifiers.TabIndex = 31;
            // 
            // chbx_Modifier_NewOnly
            // 
            this.chbx_Modifier_NewOnly.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Modifier_NewOnly.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_NewOnly.FlatAppearance.BorderSize = 0;
            this.chbx_Modifier_NewOnly.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_NewOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Modifier_NewOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Modifier_NewOnly.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Modifier_NewOnly.ImageIndex = 1;
            this.chbx_Modifier_NewOnly.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Modifier_NewOnly.Location = new System.Drawing.Point(106, 0);
            this.chbx_Modifier_NewOnly.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Modifier_NewOnly.Name = "chbx_Modifier_NewOnly";
            this.chbx_Modifier_NewOnly.Size = new System.Drawing.Size(114, 27);
            this.chbx_Modifier_NewOnly.TabIndex = 51;
            this.chbx_Modifier_NewOnly.Text = "NewOnly";
            this.chbx_Modifier_NewOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Modifier_NewOnly.UseVisualStyleBackColor = true;
            this.chbx_Modifier_NewOnly.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // lbl_Modifier_Subject
            // 
            this.lbl_Modifier_Subject.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modifier_Subject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Modifier_Subject.Location = new System.Drawing.Point(34, 106);
            this.lbl_Modifier_Subject.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Modifier_Subject.Name = "lbl_Modifier_Subject";
            this.lbl_Modifier_Subject.Size = new System.Drawing.Size(65, 21);
            this.lbl_Modifier_Subject.TabIndex = 48;
            this.lbl_Modifier_Subject.Text = "Subject";
            this.lbl_Modifier_Subject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chbx_Modifier_RunOnce
            // 
            this.chbx_Modifier_RunOnce.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Modifier_RunOnce.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_RunOnce.FlatAppearance.BorderSize = 0;
            this.chbx_Modifier_RunOnce.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_RunOnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Modifier_RunOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Modifier_RunOnce.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Modifier_RunOnce.ImageIndex = 1;
            this.chbx_Modifier_RunOnce.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Modifier_RunOnce.Location = new System.Drawing.Point(-1, 0);
            this.chbx_Modifier_RunOnce.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Modifier_RunOnce.Name = "chbx_Modifier_RunOnce";
            this.chbx_Modifier_RunOnce.Size = new System.Drawing.Size(107, 27);
            this.chbx_Modifier_RunOnce.TabIndex = 50;
            this.chbx_Modifier_RunOnce.Text = "RunOnce";
            this.chbx_Modifier_RunOnce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Modifier_RunOnce.UseVisualStyleBackColor = true;
            this.chbx_Modifier_RunOnce.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // lbl_Modifier_Owner
            // 
            this.lbl_Modifier_Owner.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modifier_Owner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Modifier_Owner.Location = new System.Drawing.Point(34, 78);
            this.lbl_Modifier_Owner.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Modifier_Owner.Name = "lbl_Modifier_Owner";
            this.lbl_Modifier_Owner.Size = new System.Drawing.Size(65, 21);
            this.lbl_Modifier_Owner.TabIndex = 47;
            this.lbl_Modifier_Owner.Text = "Owner";
            this.lbl_Modifier_Owner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chbx_Modifier_Repeatable
            // 
            this.chbx_Modifier_Repeatable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Modifier_Repeatable.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_Repeatable.FlatAppearance.BorderSize = 0;
            this.chbx_Modifier_Repeatable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_Repeatable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Modifier_Repeatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Modifier_Repeatable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Modifier_Repeatable.ImageIndex = 1;
            this.chbx_Modifier_Repeatable.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Modifier_Repeatable.Location = new System.Drawing.Point(-1, 27);
            this.chbx_Modifier_Repeatable.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Modifier_Repeatable.Name = "chbx_Modifier_Repeatable";
            this.chbx_Modifier_Repeatable.Size = new System.Drawing.Size(109, 27);
            this.chbx_Modifier_Repeatable.TabIndex = 49;
            this.chbx_Modifier_Repeatable.Text = "Repeatable";
            this.chbx_Modifier_Repeatable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Modifier_Repeatable.UseVisualStyleBackColor = true;
            this.chbx_Modifier_Repeatable.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // lbl_Modifier_StackLimit
            // 
            this.lbl_Modifier_StackLimit.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modifier_StackLimit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Modifier_StackLimit.Location = new System.Drawing.Point(530, 55);
            this.lbl_Modifier_StackLimit.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Modifier_StackLimit.Name = "lbl_Modifier_StackLimit";
            this.lbl_Modifier_StackLimit.Size = new System.Drawing.Size(84, 21);
            this.lbl_Modifier_StackLimit.TabIndex = 44;
            this.lbl_Modifier_StackLimit.Text = "StackLimit";
            this.lbl_Modifier_StackLimit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_Modifier_RequirementSetID
            // 
            this.lbl_Modifier_RequirementSetID.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modifier_RequirementSetID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Modifier_RequirementSetID.Location = new System.Drawing.Point(109, 54);
            this.lbl_Modifier_RequirementSetID.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Modifier_RequirementSetID.Name = "lbl_Modifier_RequirementSetID";
            this.lbl_Modifier_RequirementSetID.Size = new System.Drawing.Size(422, 21);
            this.lbl_Modifier_RequirementSetID.TabIndex = 45;
            this.lbl_Modifier_RequirementSetID.Text = "RequirementSetID";
            this.lbl_Modifier_RequirementSetID.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_Modifier_ModifierType
            // 
            this.lbl_Modifier_ModifierType.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modifier_ModifierType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Modifier_ModifierType.Location = new System.Drawing.Point(109, 3);
            this.lbl_Modifier_ModifierType.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Modifier_ModifierType.Name = "lbl_Modifier_ModifierType";
            this.lbl_Modifier_ModifierType.Size = new System.Drawing.Size(422, 21);
            this.lbl_Modifier_ModifierType.TabIndex = 44;
            this.lbl_Modifier_ModifierType.Text = "ModifierType";
            this.lbl_Modifier_ModifierType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbx_Modifier_ModifierType
            // 
            this.cbx_Modifier_ModifierType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Modifier_ModifierType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Modifier_ModifierType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Modifier_ModifierType.FormattingEnabled = true;
            this.cbx_Modifier_ModifierType.Location = new System.Drawing.Point(109, 27);
            this.cbx_Modifier_ModifierType.Name = "cbx_Modifier_ModifierType";
            this.cbx_Modifier_ModifierType.Size = new System.Drawing.Size(422, 24);
            this.cbx_Modifier_ModifierType.Sorted = true;
            this.cbx_Modifier_ModifierType.TabIndex = 31;
            this.cbx_Modifier_ModifierType.Click += new System.EventHandler(this.AllComboBoxes_Click);
            // 
            // tbx_Modifier_SubjectStackLimit
            // 
            this.tbx_Modifier_SubjectStackLimit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbx_Modifier_SubjectStackLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Modifier_SubjectStackLimit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Modifier_SubjectStackLimit.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Modifier_SubjectStackLimit.Location = new System.Drawing.Point(545, 105);
            this.tbx_Modifier_SubjectStackLimit.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Modifier_SubjectStackLimit.Name = "tbx_Modifier_SubjectStackLimit";
            this.tbx_Modifier_SubjectStackLimit.Size = new System.Drawing.Size(60, 25);
            this.tbx_Modifier_SubjectStackLimit.TabIndex = 24;
            this.tbx_Modifier_SubjectStackLimit.WordWrap = false;
            // 
            // cbx_Modifier_SubjectRequirementSetID
            // 
            this.cbx_Modifier_SubjectRequirementSetID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Modifier_SubjectRequirementSetID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Modifier_SubjectRequirementSetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Modifier_SubjectRequirementSetID.FormattingEnabled = true;
            this.cbx_Modifier_SubjectRequirementSetID.Location = new System.Drawing.Point(109, 105);
            this.cbx_Modifier_SubjectRequirementSetID.Name = "cbx_Modifier_SubjectRequirementSetID";
            this.cbx_Modifier_SubjectRequirementSetID.Size = new System.Drawing.Size(422, 24);
            this.cbx_Modifier_SubjectRequirementSetID.Sorted = true;
            this.cbx_Modifier_SubjectRequirementSetID.TabIndex = 26;
            this.cbx_Modifier_SubjectRequirementSetID.Click += new System.EventHandler(this.AllComboBoxes_Click);
            // 
            // tbx_Modifier_OwnerStackLimit
            // 
            this.tbx_Modifier_OwnerStackLimit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbx_Modifier_OwnerStackLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Modifier_OwnerStackLimit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Modifier_OwnerStackLimit.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Modifier_OwnerStackLimit.Location = new System.Drawing.Point(545, 78);
            this.tbx_Modifier_OwnerStackLimit.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Modifier_OwnerStackLimit.Name = "tbx_Modifier_OwnerStackLimit";
            this.tbx_Modifier_OwnerStackLimit.Size = new System.Drawing.Size(60, 25);
            this.tbx_Modifier_OwnerStackLimit.TabIndex = 23;
            this.tbx_Modifier_OwnerStackLimit.WordWrap = false;
            // 
            // cbx_Modifier_OwnerRequirementSetID
            // 
            this.cbx_Modifier_OwnerRequirementSetID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Modifier_OwnerRequirementSetID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Modifier_OwnerRequirementSetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Modifier_OwnerRequirementSetID.FormattingEnabled = true;
            this.cbx_Modifier_OwnerRequirementSetID.Location = new System.Drawing.Point(109, 78);
            this.cbx_Modifier_OwnerRequirementSetID.Name = "cbx_Modifier_OwnerRequirementSetID";
            this.cbx_Modifier_OwnerRequirementSetID.Size = new System.Drawing.Size(422, 24);
            this.cbx_Modifier_OwnerRequirementSetID.Sorted = true;
            this.cbx_Modifier_OwnerRequirementSetID.TabIndex = 25;
            this.cbx_Modifier_OwnerRequirementSetID.Click += new System.EventHandler(this.AllComboBoxes_Click);
            // 
            // chbx_Modifier_Permanent
            // 
            this.chbx_Modifier_Permanent.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Modifier_Permanent.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_Permanent.FlatAppearance.BorderSize = 0;
            this.chbx_Modifier_Permanent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Modifier_Permanent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Modifier_Permanent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Modifier_Permanent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Modifier_Permanent.ImageIndex = 1;
            this.chbx_Modifier_Permanent.ImageList = this.IconsGeneral_ImageList;
            this.chbx_Modifier_Permanent.Location = new System.Drawing.Point(-1, 54);
            this.chbx_Modifier_Permanent.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Modifier_Permanent.Name = "chbx_Modifier_Permanent";
            this.chbx_Modifier_Permanent.Size = new System.Drawing.Size(107, 27);
            this.chbx_Modifier_Permanent.TabIndex = 29;
            this.chbx_Modifier_Permanent.Text = "Permanent";
            this.chbx_Modifier_Permanent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Modifier_Permanent.UseVisualStyleBackColor = true;
            this.chbx_Modifier_Permanent.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged_ImageList);
            // 
            // GridView_RequirementArguments
            // 
            this.GridView_RequirementArguments.AllowUserToAddRows = false;
            this.GridView_RequirementArguments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_RequirementArguments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_RequirementArguments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_RequirementArguments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_RequirementArguments_Col_Name,
            this.GV_RequirementArguments_Col_Value,
            this.GV_RequirementArguments_Col_Type,
            this.GV_RequirementArguments_Col_Extra,
            this.GV_RequirementArguments_Col_SecondExtra});
            this.GridView_RequirementArguments.Location = new System.Drawing.Point(1107, 231);
            this.GridView_RequirementArguments.MultiSelect = false;
            this.GridView_RequirementArguments.Name = "GridView_RequirementArguments";
            this.GridView_RequirementArguments.RowHeadersVisible = false;
            this.GridView_RequirementArguments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_RequirementArguments.Size = new System.Drawing.Size(411, 110);
            this.GridView_RequirementArguments.TabIndex = 22;
            this.GridView_RequirementArguments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // GV_RequirementArguments_Col_Name
            // 
            this.GV_RequirementArguments_Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_RequirementArguments_Col_Name.HeaderText = "Name";
            this.GV_RequirementArguments_Col_Name.Name = "GV_RequirementArguments_Col_Name";
            this.GV_RequirementArguments_Col_Name.Width = 200;
            // 
            // GV_RequirementArguments_Col_Value
            // 
            this.GV_RequirementArguments_Col_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_RequirementArguments_Col_Value.HeaderText = "Value";
            this.GV_RequirementArguments_Col_Value.MinimumWidth = 200;
            this.GV_RequirementArguments_Col_Value.Name = "GV_RequirementArguments_Col_Value";
            // 
            // GV_RequirementArguments_Col_Type
            // 
            this.GV_RequirementArguments_Col_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_RequirementArguments_Col_Type.HeaderText = "Type";
            this.GV_RequirementArguments_Col_Type.Name = "GV_RequirementArguments_Col_Type";
            this.GV_RequirementArguments_Col_Type.Width = 50;
            // 
            // GV_RequirementArguments_Col_Extra
            // 
            this.GV_RequirementArguments_Col_Extra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_RequirementArguments_Col_Extra.HeaderText = "Extra";
            this.GV_RequirementArguments_Col_Extra.Name = "GV_RequirementArguments_Col_Extra";
            this.GV_RequirementArguments_Col_Extra.Width = 50;
            // 
            // GV_RequirementArguments_Col_SecondExtra
            // 
            this.GV_RequirementArguments_Col_SecondExtra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_RequirementArguments_Col_SecondExtra.HeaderText = "SecondExtra";
            this.GV_RequirementArguments_Col_SecondExtra.Name = "GV_RequirementArguments_Col_SecondExtra";
            this.GV_RequirementArguments_Col_SecondExtra.Width = 50;
            // 
            // GridView_RequirementSetRequirements
            // 
            this.GridView_RequirementSetRequirements.AllowUserToAddRows = false;
            this.GridView_RequirementSetRequirements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_RequirementSetRequirements.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_RequirementSetRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_RequirementSetRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_RequirementSetRequirements_Col_RequirementID});
            this.GridView_RequirementSetRequirements.Location = new System.Drawing.Point(249, 231);
            this.GridView_RequirementSetRequirements.MultiSelect = false;
            this.GridView_RequirementSetRequirements.Name = "GridView_RequirementSetRequirements";
            this.GridView_RequirementSetRequirements.RowHeadersVisible = false;
            this.GridView_RequirementSetRequirements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_RequirementSetRequirements.Size = new System.Drawing.Size(225, 110);
            this.GridView_RequirementSetRequirements.TabIndex = 20;
            this.GridView_RequirementSetRequirements.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            this.GridView_RequirementSetRequirements.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_RequirementSetRequirements_RowEnter);
            // 
            // GV_RequirementSetRequirements_Col_RequirementID
            // 
            this.GV_RequirementSetRequirements_Col_RequirementID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_RequirementSetRequirements_Col_RequirementID.HeaderText = "RequirementID";
            this.GV_RequirementSetRequirements_Col_RequirementID.Name = "GV_RequirementSetRequirements_Col_RequirementID";
            // 
            // GridView_RequirementSets
            // 
            this.GridView_RequirementSets.AllowUserToAddRows = false;
            this.GridView_RequirementSets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_RequirementSets.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_RequirementSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_RequirementSets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_RequirementSets_Col_RequirementSetID,
            this.GV_RequirementSets_Col_RequirementSetType});
            this.GridView_RequirementSets.Location = new System.Drawing.Point(2, 231);
            this.GridView_RequirementSets.MultiSelect = false;
            this.GridView_RequirementSets.Name = "GridView_RequirementSets";
            this.GridView_RequirementSets.RowHeadersVisible = false;
            this.GridView_RequirementSets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_RequirementSets.Size = new System.Drawing.Size(239, 110);
            this.GridView_RequirementSets.TabIndex = 19;
            this.GridView_RequirementSets.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_RequirementSets.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_RequirementSets_RowEnter);
            // 
            // GV_RequirementSets_Col_RequirementSetID
            // 
            this.GV_RequirementSets_Col_RequirementSetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_RequirementSets_Col_RequirementSetID.HeaderText = "RequirementSetID";
            this.GV_RequirementSets_Col_RequirementSetID.MinimumWidth = 150;
            this.GV_RequirementSets_Col_RequirementSetID.Name = "GV_RequirementSets_Col_RequirementSetID";
            // 
            // GV_RequirementSets_Col_RequirementSetType
            // 
            this.GV_RequirementSets_Col_RequirementSetType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_RequirementSets_Col_RequirementSetType.HeaderText = "RequirementSetType";
            this.GV_RequirementSets_Col_RequirementSetType.Items.AddRange(new object[] {
            "REQUIREMENTSET_TEST_ALL",
            "REQUIREMENTSET_TEST_ANY"});
            this.GV_RequirementSets_Col_RequirementSetType.Name = "GV_RequirementSets_Col_RequirementSetType";
            this.GV_RequirementSets_Col_RequirementSetType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_RequirementSets_Col_RequirementSetType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GV_RequirementSets_Col_RequirementSetType.Width = 200;
            // 
            // GridView_Requirements
            // 
            this.GridView_Requirements.AllowUserToAddRows = false;
            this.GridView_Requirements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_Requirements.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_Requirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Requirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_Requirements_Col_RequirementID,
            this.GV_Requirements_Col_RequirementType});
            this.GridView_Requirements.Location = new System.Drawing.Point(9, 627);
            this.GridView_Requirements.MultiSelect = false;
            this.GridView_Requirements.Name = "GridView_Requirements";
            this.GridView_Requirements.RowHeadersVisible = false;
            this.GridView_Requirements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_Requirements.Size = new System.Drawing.Size(466, 153);
            this.GridView_Requirements.TabIndex = 17;
            this.GridView_Requirements.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_Requirements.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Requirements_RowEnter);
            // 
            // GV_Requirements_Col_RequirementID
            // 
            this.GV_Requirements_Col_RequirementID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_Requirements_Col_RequirementID.HeaderText = "RequirementID";
            this.GV_Requirements_Col_RequirementID.Name = "GV_Requirements_Col_RequirementID";
            this.GV_Requirements_Col_RequirementID.Width = 250;
            // 
            // GV_Requirements_Col_RequirementType
            // 
            this.GV_Requirements_Col_RequirementType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_Requirements_Col_RequirementType.HeaderText = "RequirementType";
            this.GV_Requirements_Col_RequirementType.Name = "GV_Requirements_Col_RequirementType";
            // 
            // GridView_ModifierArguments
            // 
            this.GridView_ModifierArguments.AllowUserToAddRows = false;
            this.GridView_ModifierArguments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_ModifierArguments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_ModifierArguments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_ModifierArguments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_ModifierArguments_Col_Name,
            this.GV_ModifierArguments_Col_Value,
            this.GV_ModifierArguments_Col_Type,
            this.GV_ModifierArguments_Col_Extra,
            this.GV_ModifierArguments_Col_SecondExtra});
            this.GridView_ModifierArguments.Location = new System.Drawing.Point(1108, 30);
            this.GridView_ModifierArguments.MultiSelect = false;
            this.GridView_ModifierArguments.Name = "GridView_ModifierArguments";
            this.GridView_ModifierArguments.RowHeadersVisible = false;
            this.GridView_ModifierArguments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_ModifierArguments.Size = new System.Drawing.Size(411, 136);
            this.GridView_ModifierArguments.TabIndex = 15;
            this.GridView_ModifierArguments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // GV_ModifierArguments_Col_Name
            // 
            this.GV_ModifierArguments_Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_ModifierArguments_Col_Name.HeaderText = "Name";
            this.GV_ModifierArguments_Col_Name.Name = "GV_ModifierArguments_Col_Name";
            this.GV_ModifierArguments_Col_Name.Width = 200;
            // 
            // GV_ModifierArguments_Col_Value
            // 
            this.GV_ModifierArguments_Col_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ModifierArguments_Col_Value.HeaderText = "Value";
            this.GV_ModifierArguments_Col_Value.MinimumWidth = 200;
            this.GV_ModifierArguments_Col_Value.Name = "GV_ModifierArguments_Col_Value";
            // 
            // GV_ModifierArguments_Col_Type
            // 
            this.GV_ModifierArguments_Col_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_ModifierArguments_Col_Type.HeaderText = "Type";
            this.GV_ModifierArguments_Col_Type.Name = "GV_ModifierArguments_Col_Type";
            this.GV_ModifierArguments_Col_Type.Width = 50;
            // 
            // GV_ModifierArguments_Col_Extra
            // 
            this.GV_ModifierArguments_Col_Extra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_ModifierArguments_Col_Extra.HeaderText = "Extra";
            this.GV_ModifierArguments_Col_Extra.Name = "GV_ModifierArguments_Col_Extra";
            this.GV_ModifierArguments_Col_Extra.Width = 50;
            // 
            // GV_ModifierArguments_Col_SecondExtra
            // 
            this.GV_ModifierArguments_Col_SecondExtra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_ModifierArguments_Col_SecondExtra.HeaderText = "SecondExtra";
            this.GV_ModifierArguments_Col_SecondExtra.Name = "GV_ModifierArguments_Col_SecondExtra";
            this.GV_ModifierArguments_Col_SecondExtra.Width = 50;
            // 
            // GridView_Modifiers
            // 
            this.GridView_Modifiers.AllowUserToAddRows = false;
            this.GridView_Modifiers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_Modifiers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_Modifiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Modifiers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_Modifiers_Col_ModifierID,
            this.GV_Modifiers_Col_ModifierType});
            this.GridView_Modifiers.Location = new System.Drawing.Point(3, 5);
            this.GridView_Modifiers.MultiSelect = false;
            this.GridView_Modifiers.Name = "GridView_Modifiers";
            this.GridView_Modifiers.RowHeadersVisible = false;
            this.GridView_Modifiers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_Modifiers.Size = new System.Drawing.Size(466, 161);
            this.GridView_Modifiers.TabIndex = 14;
            this.GridView_Modifiers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_Modifiers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Modifiers_RowEnter);
            // 
            // GV_Modifiers_Col_ModifierID
            // 
            this.GV_Modifiers_Col_ModifierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_Modifiers_Col_ModifierID.HeaderText = "ModifierID";
            this.GV_Modifiers_Col_ModifierID.Name = "GV_Modifiers_Col_ModifierID";
            this.GV_Modifiers_Col_ModifierID.Width = 250;
            // 
            // GV_Modifiers_Col_ModifierType
            // 
            this.GV_Modifiers_Col_ModifierType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_Modifiers_Col_ModifierType.HeaderText = "ModifierType";
            this.GV_Modifiers_Col_ModifierType.Name = "GV_Modifiers_Col_ModifierType";
            // 
            // tab_UnitPromotions
            // 
            this.tab_UnitPromotions.Controls.Add(this.panel3);
            this.tab_UnitPromotions.Controls.Add(this.panel4);
            this.tab_UnitPromotions.Controls.Add(this.AddUnitPromotion_Btn);
            this.tab_UnitPromotions.Controls.Add(this.AddUnitPromotionClasse_Btn);
            this.tab_UnitPromotions.Controls.Add(this.GridView_UnitPromotionPrereqs);
            this.tab_UnitPromotions.Controls.Add(this.panel1);
            this.tab_UnitPromotions.Controls.Add(this.GridView_UnitPromotionClasses);
            this.tab_UnitPromotions.Controls.Add(this.GridView_UnitPromotions);
            this.tab_UnitPromotions.Controls.Add(this.Panel_PromotionClassPromotions);
            this.tab_UnitPromotions.Location = new System.Drawing.Point(4, 22);
            this.tab_UnitPromotions.Margin = new System.Windows.Forms.Padding(2);
            this.tab_UnitPromotions.Name = "tab_UnitPromotions";
            this.tab_UnitPromotions.Padding = new System.Windows.Forms.Padding(2);
            this.tab_UnitPromotions.Size = new System.Drawing.Size(1643, 996);
            this.tab_UnitPromotions.TabIndex = 1;
            this.tab_UnitPromotions.Text = "UnitPromotions";
            this.tab_UnitPromotions.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(848, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 743);
            this.panel3.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(0, 556);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 37);
            this.label11.TabIndex = 51;
            this.label11.Text = "4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(-7, 421);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 37);
            this.label10.TabIndex = 50;
            this.label10.Text = "3";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(-3, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 37);
            this.label9.TabIndex = 49;
            this.label9.Text = "2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(-7, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 37);
            this.label8.TabIndex = 48;
            this.label8.Text = "1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 42;
            this.label1.Text = "Level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.CurrentPromotionClass_Label);
            this.panel4.Location = new System.Drawing.Point(5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 112);
            this.panel4.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(0, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Column:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(676, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 37);
            this.label7.TabIndex = 47;
            this.label7.Text = "5";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(525, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 37);
            this.label6.TabIndex = 46;
            this.label6.Text = "4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(374, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 37);
            this.label5.TabIndex = 45;
            this.label5.Text = "3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(223, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 37);
            this.label4.TabIndex = 44;
            this.label4.Text = "2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(72, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CurrentPromotionClass_Label
            // 
            this.CurrentPromotionClass_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.CurrentPromotionClass_Label.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentPromotionClass_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.CurrentPromotionClass_Label.Location = new System.Drawing.Point(0, 1);
            this.CurrentPromotionClass_Label.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentPromotionClass_Label.Name = "CurrentPromotionClass_Label";
            this.CurrentPromotionClass_Label.Size = new System.Drawing.Size(845, 42);
            this.CurrentPromotionClass_Label.TabIndex = 35;
            this.CurrentPromotionClass_Label.Text = "Current Promotion Class";
            this.CurrentPromotionClass_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AddUnitPromotion_Btn
            // 
            this.AddUnitPromotion_Btn.Location = new System.Drawing.Point(1015, 469);
            this.AddUnitPromotion_Btn.Name = "AddUnitPromotion_Btn";
            this.AddUnitPromotion_Btn.Size = new System.Drawing.Size(120, 23);
            this.AddUnitPromotion_Btn.TabIndex = 41;
            this.AddUnitPromotion_Btn.Text = "Add New Promotion";
            this.AddUnitPromotion_Btn.UseVisualStyleBackColor = true;
            this.AddUnitPromotion_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // AddUnitPromotionClasse_Btn
            // 
            this.AddUnitPromotionClasse_Btn.Location = new System.Drawing.Point(1015, 207);
            this.AddUnitPromotionClasse_Btn.Name = "AddUnitPromotionClasse_Btn";
            this.AddUnitPromotionClasse_Btn.Size = new System.Drawing.Size(144, 23);
            this.AddUnitPromotionClasse_Btn.TabIndex = 40;
            this.AddUnitPromotionClasse_Btn.Text = "Add New Promotion Class";
            this.AddUnitPromotionClasse_Btn.UseVisualStyleBackColor = true;
            this.AddUnitPromotionClasse_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // GridView_UnitPromotionPrereqs
            // 
            this.GridView_UnitPromotionPrereqs.AllowUserToAddRows = false;
            this.GridView_UnitPromotionPrereqs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitPromotionPrereqs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitPromotionPrereqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitPromotionPrereqs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion});
            this.GridView_UnitPromotionPrereqs.Location = new System.Drawing.Point(1153, 469);
            this.GridView_UnitPromotionPrereqs.MultiSelect = false;
            this.GridView_UnitPromotionPrereqs.Name = "GridView_UnitPromotionPrereqs";
            this.GridView_UnitPromotionPrereqs.RowHeadersVisible = false;
            this.GridView_UnitPromotionPrereqs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitPromotionPrereqs.Size = new System.Drawing.Size(360, 101);
            this.GridView_UnitPromotionPrereqs.TabIndex = 27;
            this.GridView_UnitPromotionPrereqs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion
            // 
            this.GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion.HeaderText = "PrereqUnitPromotion";
            this.GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion.MinimumWidth = 100;
            this.GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion.Name = "GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1116, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 125);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(119, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 48);
            this.panel2.TabIndex = 0;
            // 
            // GridView_UnitPromotionClasses
            // 
            this.GridView_UnitPromotionClasses.AllowUserToAddRows = false;
            this.GridView_UnitPromotionClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitPromotionClasses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitPromotionClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitPromotionClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_UnitPromotionClasses_Col_PromotionClassType,
            this.GV_UnitPromotionClasses_Col_Name});
            this.GridView_UnitPromotionClasses.Location = new System.Drawing.Point(1015, 5);
            this.GridView_UnitPromotionClasses.MultiSelect = false;
            this.GridView_UnitPromotionClasses.Name = "GridView_UnitPromotionClasses";
            this.GridView_UnitPromotionClasses.RowHeadersVisible = false;
            this.GridView_UnitPromotionClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitPromotionClasses.Size = new System.Drawing.Size(498, 196);
            this.GridView_UnitPromotionClasses.TabIndex = 23;
            this.GridView_UnitPromotionClasses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_UnitPromotionClasses.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_UnitPromotionClasses_RowEnter);
            // 
            // GV_UnitPromotionClasses_Col_PromotionClassType
            // 
            this.GV_UnitPromotionClasses_Col_PromotionClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_UnitPromotionClasses_Col_PromotionClassType.HeaderText = "PromotionClassType";
            this.GV_UnitPromotionClasses_Col_PromotionClassType.Name = "GV_UnitPromotionClasses_Col_PromotionClassType";
            this.GV_UnitPromotionClasses_Col_PromotionClassType.Width = 250;
            // 
            // GV_UnitPromotionClasses_Col_Name
            // 
            this.GV_UnitPromotionClasses_Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnitPromotionClasses_Col_Name.HeaderText = "Name";
            this.GV_UnitPromotionClasses_Col_Name.MinimumWidth = 100;
            this.GV_UnitPromotionClasses_Col_Name.Name = "GV_UnitPromotionClasses_Col_Name";
            // 
            // GridView_UnitPromotions
            // 
            this.GridView_UnitPromotions.AllowUserToAddRows = false;
            this.GridView_UnitPromotions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitPromotions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitPromotions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitPromotions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_UnitPromotions_Col_UnitPromotionType,
            this.GV_UnitPromotions_Col_Name,
            this.GV_UnitPromotions_Col_Description,
            this.GV_UnitPromotions_Col_Level,
            this.GV_UnitPromotions_Col_Specialization,
            this.GV_UnitPromotions_Col_PromotionClass,
            this.GV_UnitPromotions_Col_Column});
            this.GridView_UnitPromotions.Location = new System.Drawing.Point(1015, 241);
            this.GridView_UnitPromotions.MultiSelect = false;
            this.GridView_UnitPromotions.Name = "GridView_UnitPromotions";
            this.GridView_UnitPromotions.RowHeadersVisible = false;
            this.GridView_UnitPromotions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitPromotions.Size = new System.Drawing.Size(498, 222);
            this.GridView_UnitPromotions.TabIndex = 22;
            this.GridView_UnitPromotions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_UnitPromotions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_UnitPromotions_RowEnter);
            // 
            // GV_UnitPromotions_Col_UnitPromotionType
            // 
            this.GV_UnitPromotions_Col_UnitPromotionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_UnitPromotions_Col_UnitPromotionType.HeaderText = "UnitPromotionType";
            this.GV_UnitPromotions_Col_UnitPromotionType.Name = "GV_UnitPromotions_Col_UnitPromotionType";
            this.GV_UnitPromotions_Col_UnitPromotionType.Width = 150;
            // 
            // GV_UnitPromotions_Col_Name
            // 
            this.GV_UnitPromotions_Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnitPromotions_Col_Name.HeaderText = "Name";
            this.GV_UnitPromotions_Col_Name.MinimumWidth = 100;
            this.GV_UnitPromotions_Col_Name.Name = "GV_UnitPromotions_Col_Name";
            // 
            // GV_UnitPromotions_Col_Description
            // 
            this.GV_UnitPromotions_Col_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_UnitPromotions_Col_Description.HeaderText = "Description";
            this.GV_UnitPromotions_Col_Description.Name = "GV_UnitPromotions_Col_Description";
            this.GV_UnitPromotions_Col_Description.Width = 150;
            // 
            // GV_UnitPromotions_Col_Level
            // 
            this.GV_UnitPromotions_Col_Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_UnitPromotions_Col_Level.HeaderText = "Level";
            this.GV_UnitPromotions_Col_Level.Name = "GV_UnitPromotions_Col_Level";
            this.GV_UnitPromotions_Col_Level.Width = 70;
            // 
            // GV_UnitPromotions_Col_Specialization
            // 
            this.GV_UnitPromotions_Col_Specialization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_UnitPromotions_Col_Specialization.HeaderText = "Specialization";
            this.GV_UnitPromotions_Col_Specialization.Name = "GV_UnitPromotions_Col_Specialization";
            this.GV_UnitPromotions_Col_Specialization.Width = 50;
            // 
            // GV_UnitPromotions_Col_PromotionClass
            // 
            this.GV_UnitPromotions_Col_PromotionClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GV_UnitPromotions_Col_PromotionClass.HeaderText = "PromotionClass";
            this.GV_UnitPromotions_Col_PromotionClass.Name = "GV_UnitPromotions_Col_PromotionClass";
            this.GV_UnitPromotions_Col_PromotionClass.Width = 83;
            // 
            // GV_UnitPromotions_Col_Column
            // 
            this.GV_UnitPromotions_Col_Column.HeaderText = "Column";
            this.GV_UnitPromotions_Col_Column.Name = "GV_UnitPromotions_Col_Column";
            this.GV_UnitPromotions_Col_Column.Width = 101;
            // 
            // Panel_PromotionClassPromotions
            // 
            this.Panel_PromotionClassPromotions.AllowDrop = true;
            this.Panel_PromotionClassPromotions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.Panel_PromotionClassPromotions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_PromotionClassPromotions.Location = new System.Drawing.Point(5, 105);
            this.Panel_PromotionClassPromotions.Name = "Panel_PromotionClassPromotions";
            this.Panel_PromotionClassPromotions.Size = new System.Drawing.Size(849, 642);
            this.Panel_PromotionClassPromotions.TabIndex = 24;
            this.Panel_PromotionClassPromotions.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_PromotionClassPromotions_Paint);
            // 
            // tab_Units
            // 
            this.tab_Units.Controls.Add(this.GridView_Unit_BuildingPrereqs);
            this.tab_Units.Controls.Add(this.chbx_ShowAbilitiesTags);
            this.tab_Units.Controls.Add(this.Panel_Table_UnitAbilities);
            this.tab_Units.Controls.Add(this.Label_UnitAbilities);
            this.tab_Units.Controls.Add(this.AddAbilityTag_Btn);
            this.tab_Units.Controls.Add(this.GridView_AbilityTags);
            this.tab_Units.Controls.Add(this.AddUnitTag_Btn);
            this.tab_Units.Controls.Add(this.AddUnitAiInfo_Btn);
            this.tab_Units.Controls.Add(this.AddUnitUpgrade_Btn);
            this.tab_Units.Controls.Add(this.AddUnitAbilitie_Btn);
            this.tab_Units.Controls.Add(this.AddUnitReplace_Btn);
            this.tab_Units.Controls.Add(this.AddUnit_Btn);
            this.tab_Units.Controls.Add(this.AddUnit_BuildingPrereq_Btn);
            this.tab_Units.Controls.Add(this.GridView_UnitAbilities);
            this.tab_Units.Controls.Add(this.GridView_UnitTags);
            this.tab_Units.Controls.Add(this.GridView_UnitAiInfos);
            this.tab_Units.Controls.Add(this.GridView_Units);
            this.tab_Units.Controls.Add(this.GridView_UnitUpgrades);
            this.tab_Units.Controls.Add(this.Panel_Table_Units);
            this.tab_Units.Controls.Add(this.GridView_UnitReplaces);
            this.tab_Units.Location = new System.Drawing.Point(4, 22);
            this.tab_Units.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Units.Name = "tab_Units";
            this.tab_Units.Size = new System.Drawing.Size(1643, 996);
            this.tab_Units.TabIndex = 0;
            this.tab_Units.Text = "Units";
            this.tab_Units.UseVisualStyleBackColor = true;
            // 
            // GridView_Unit_BuildingPrereqs
            // 
            this.GridView_Unit_BuildingPrereqs.AllowUserToAddRows = false;
            this.GridView_Unit_BuildingPrereqs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_Unit_BuildingPrereqs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.GridView_Unit_BuildingPrereqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Unit_BuildingPrereqs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding,
            this.Gridview_Unit_BuildingPrereqs_Col_NumSupported});
            this.GridView_Unit_BuildingPrereqs.Location = new System.Drawing.Point(685, 665);
            this.GridView_Unit_BuildingPrereqs.MultiSelect = false;
            this.GridView_Unit_BuildingPrereqs.Name = "GridView_Unit_BuildingPrereqs";
            this.GridView_Unit_BuildingPrereqs.RowHeadersVisible = false;
            this.GridView_Unit_BuildingPrereqs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridView_Unit_BuildingPrereqs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_Unit_BuildingPrereqs.Size = new System.Drawing.Size(331, 53);
            this.GridView_Unit_BuildingPrereqs.TabIndex = 7;
            this.GridView_Unit_BuildingPrereqs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            this.GridView_Unit_BuildingPrereqs.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GridView_Unit_BuildingPrereqs_Scroll);
            this.GridView_Unit_BuildingPrereqs.Enter += new System.EventHandler(this.GridView_Unit_BuildingPrereqs_Enter);
            this.GridView_Unit_BuildingPrereqs.Leave += new System.EventHandler(this.GridView_Unit_BuildingPrereqs_Leave);
            this.GridView_Unit_BuildingPrereqs.MouseEnter += new System.EventHandler(this.GridView_Unit_BuildingPrereqs_MouseEnter);
            this.GridView_Unit_BuildingPrereqs.MouseLeave += new System.EventHandler(this.GridView_Unit_BuildingPrereqs_MouseLeave);
            // 
            // Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding
            // 
            this.Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding.HeaderText = "PrereqBuilding";
            this.Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding.Name = "Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding";
            // 
            // Gridview_Unit_BuildingPrereqs_Col_NumSupported
            // 
            this.Gridview_Unit_BuildingPrereqs_Col_NumSupported.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gridview_Unit_BuildingPrereqs_Col_NumSupported.HeaderText = "NumSupported";
            this.Gridview_Unit_BuildingPrereqs_Col_NumSupported.Name = "Gridview_Unit_BuildingPrereqs_Col_NumSupported";
            // 
            // chbx_ShowAbilitiesTags
            // 
            this.chbx_ShowAbilitiesTags.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_ShowAbilitiesTags.BackColor = System.Drawing.Color.Transparent;
            this.chbx_ShowAbilitiesTags.Checked = true;
            this.chbx_ShowAbilitiesTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_ShowAbilitiesTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_ShowAbilitiesTags.FlatAppearance.BorderSize = 0;
            this.chbx_ShowAbilitiesTags.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_ShowAbilitiesTags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_ShowAbilitiesTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_ShowAbilitiesTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_ShowAbilitiesTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_ShowAbilitiesTags.ForeColor = System.Drawing.Color.Black;
            this.chbx_ShowAbilitiesTags.Image = ((System.Drawing.Image)(resources.GetObject("chbx_ShowAbilitiesTags.Image")));
            this.chbx_ShowAbilitiesTags.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_ShowAbilitiesTags.Location = new System.Drawing.Point(1232, 218);
            this.chbx_ShowAbilitiesTags.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_ShowAbilitiesTags.Name = "chbx_ShowAbilitiesTags";
            this.chbx_ShowAbilitiesTags.Size = new System.Drawing.Size(164, 27);
            this.chbx_ShowAbilitiesTags.TabIndex = 156;
            this.chbx_ShowAbilitiesTags.Text = "Show Abilities\' Tags";
            this.chbx_ShowAbilitiesTags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_ShowAbilitiesTags.UseVisualStyleBackColor = true;
            this.chbx_ShowAbilitiesTags.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // Panel_Table_UnitAbilities
            // 
            this.Panel_Table_UnitAbilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.Panel_Table_UnitAbilities.Controls.Add(this.chbx_Abilitie_Permanent);
            this.Panel_Table_UnitAbilities.Controls.Add(this.chbx_Abilitie_ShowFloatTextWhenEarned);
            this.Panel_Table_UnitAbilities.Controls.Add(this.chbx_Abilitie_Inactive);
            this.Panel_Table_UnitAbilities.Controls.Add(this.tbx_Loc_Abilitie_Name);
            this.Panel_Table_UnitAbilities.Controls.Add(this.tbx_Loc_Abilitie_Description);
            this.Panel_Table_UnitAbilities.Location = new System.Drawing.Point(1041, 2);
            this.Panel_Table_UnitAbilities.Name = "Panel_Table_UnitAbilities";
            this.Panel_Table_UnitAbilities.Size = new System.Drawing.Size(596, 213);
            this.Panel_Table_UnitAbilities.TabIndex = 155;
            // 
            // chbx_Abilitie_Permanent
            // 
            this.chbx_Abilitie_Permanent.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Abilitie_Permanent.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Abilitie_Permanent.Checked = true;
            this.chbx_Abilitie_Permanent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_Abilitie_Permanent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Abilitie_Permanent.FlatAppearance.BorderSize = 0;
            this.chbx_Abilitie_Permanent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Abilitie_Permanent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Abilitie_Permanent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Abilitie_Permanent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Abilitie_Permanent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Abilitie_Permanent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Abilitie_Permanent.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Abilitie_Permanent.Image")));
            this.chbx_Abilitie_Permanent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Abilitie_Permanent.Location = new System.Drawing.Point(4, 103);
            this.chbx_Abilitie_Permanent.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Abilitie_Permanent.Name = "chbx_Abilitie_Permanent";
            this.chbx_Abilitie_Permanent.Size = new System.Drawing.Size(116, 27);
            this.chbx_Abilitie_Permanent.TabIndex = 151;
            this.chbx_Abilitie_Permanent.Text = "Permanent";
            this.chbx_Abilitie_Permanent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Abilitie_Permanent.UseVisualStyleBackColor = true;
            this.chbx_Abilitie_Permanent.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Abilitie_ShowFloatTextWhenEarned
            // 
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.FlatAppearance.BorderSize = 0;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Abilitie_ShowFloatTextWhenEarned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Abilitie_ShowFloatTextWhenEarned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Abilitie_ShowFloatTextWhenEarned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Abilitie_ShowFloatTextWhenEarned.Image")));
            this.chbx_Abilitie_ShowFloatTextWhenEarned.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Location = new System.Drawing.Point(4, 74);
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Name = "chbx_Abilitie_ShowFloatTextWhenEarned";
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Size = new System.Drawing.Size(214, 27);
            this.chbx_Abilitie_ShowFloatTextWhenEarned.TabIndex = 155;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.Text = "ShowFloatTextWhenEarned";
            this.chbx_Abilitie_ShowFloatTextWhenEarned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.UseVisualStyleBackColor = true;
            this.chbx_Abilitie_ShowFloatTextWhenEarned.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Abilitie_Inactive
            // 
            this.chbx_Abilitie_Inactive.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Abilitie_Inactive.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Abilitie_Inactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Abilitie_Inactive.FlatAppearance.BorderSize = 0;
            this.chbx_Abilitie_Inactive.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Abilitie_Inactive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Abilitie_Inactive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Abilitie_Inactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Abilitie_Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Abilitie_Inactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Abilitie_Inactive.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Abilitie_Inactive.Image")));
            this.chbx_Abilitie_Inactive.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Abilitie_Inactive.Location = new System.Drawing.Point(4, 45);
            this.chbx_Abilitie_Inactive.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Abilitie_Inactive.Name = "chbx_Abilitie_Inactive";
            this.chbx_Abilitie_Inactive.Size = new System.Drawing.Size(126, 27);
            this.chbx_Abilitie_Inactive.TabIndex = 153;
            this.chbx_Abilitie_Inactive.Text = "Inactive";
            this.chbx_Abilitie_Inactive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Abilitie_Inactive.UseVisualStyleBackColor = true;
            this.chbx_Abilitie_Inactive.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Loc_Abilitie_Name
            // 
            this.tbx_Loc_Abilitie_Name.BackAlpha = 255;
            this.tbx_Loc_Abilitie_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.tbx_Loc_Abilitie_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Loc_Abilitie_Name.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Loc_Abilitie_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Loc_Abilitie_Name.Location = new System.Drawing.Point(225, 3);
            this.tbx_Loc_Abilitie_Name.Multiline = true;
            this.tbx_Loc_Abilitie_Name.Name = "tbx_Loc_Abilitie_Name";
            this.tbx_Loc_Abilitie_Name.Size = new System.Drawing.Size(368, 32);
            this.tbx_Loc_Abilitie_Name.TabIndex = 154;
            this.tbx_Loc_Abilitie_Name.Text = "Ability Name";
            this.tbx_Loc_Abilitie_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Loc_Abilitie_Description
            // 
            this.tbx_Loc_Abilitie_Description.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Loc_Abilitie_Description.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Loc_Abilitie_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Loc_Abilitie_Description.Location = new System.Drawing.Point(225, 45);
            this.tbx_Loc_Abilitie_Description.Name = "tbx_Loc_Abilitie_Description";
            this.tbx_Loc_Abilitie_Description.Size = new System.Drawing.Size(368, 164);
            this.tbx_Loc_Abilitie_Description.TabIndex = 154;
            this.tbx_Loc_Abilitie_Description.Text = "";
            // 
            // Label_UnitAbilities
            // 
            this.Label_UnitAbilities.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UnitAbilities.Location = new System.Drawing.Point(1038, 218);
            this.Label_UnitAbilities.Margin = new System.Windows.Forms.Padding(0);
            this.Label_UnitAbilities.Name = "Label_UnitAbilities";
            this.Label_UnitAbilities.Size = new System.Drawing.Size(188, 27);
            this.Label_UnitAbilities.TabIndex = 54;
            this.Label_UnitAbilities.Text = "UnitAbilities";
            this.Label_UnitAbilities.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AddAbilityTag_Btn
            // 
            this.AddAbilityTag_Btn.Location = new System.Drawing.Point(1043, 560);
            this.AddAbilityTag_Btn.Name = "AddAbilityTag_Btn";
            this.AddAbilityTag_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddAbilityTag_Btn.TabIndex = 53;
            this.AddAbilityTag_Btn.Text = "Add Tag to Ability";
            this.AddAbilityTag_Btn.UseVisualStyleBackColor = true;
            this.AddAbilityTag_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // GridView_AbilityTags
            // 
            this.GridView_AbilityTags.AllowUserToAddRows = false;
            this.GridView_AbilityTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_AbilityTags.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_AbilityTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_AbilityTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.GridView_AbilityTags.Location = new System.Drawing.Point(1043, 400);
            this.GridView_AbilityTags.MultiSelect = false;
            this.GridView_AbilityTags.Name = "GridView_AbilityTags";
            this.GridView_AbilityTags.RowHeadersVisible = false;
            this.GridView_AbilityTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_AbilityTags.Size = new System.Drawing.Size(185, 154);
            this.GridView_AbilityTags.TabIndex = 52;
            this.GridView_AbilityTags.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // AddUnitTag_Btn
            // 
            this.AddUnitTag_Btn.Location = new System.Drawing.Point(1319, 456);
            this.AddUnitTag_Btn.Name = "AddUnitTag_Btn";
            this.AddUnitTag_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddUnitTag_Btn.TabIndex = 51;
            this.AddUnitTag_Btn.Text = "Add Tag to Unit";
            this.AddUnitTag_Btn.UseVisualStyleBackColor = true;
            this.AddUnitTag_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // AddUnitAiInfo_Btn
            // 
            this.AddUnitAiInfo_Btn.Location = new System.Drawing.Point(1266, 859);
            this.AddUnitAiInfo_Btn.Name = "AddUnitAiInfo_Btn";
            this.AddUnitAiInfo_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddUnitAiInfo_Btn.TabIndex = 50;
            this.AddUnitAiInfo_Btn.Text = "Add Unit AI Info";
            this.AddUnitAiInfo_Btn.UseVisualStyleBackColor = true;
            this.AddUnitAiInfo_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // AddUnitUpgrade_Btn
            // 
            this.AddUnitUpgrade_Btn.Location = new System.Drawing.Point(1401, 638);
            this.AddUnitUpgrade_Btn.Name = "AddUnitUpgrade_Btn";
            this.AddUnitUpgrade_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddUnitUpgrade_Btn.TabIndex = 49;
            this.AddUnitUpgrade_Btn.Text = "Add Upgrade Unit";
            this.AddUnitUpgrade_Btn.UseVisualStyleBackColor = true;
            this.AddUnitUpgrade_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // AddUnitAbilitie_Btn
            // 
            this.AddUnitAbilitie_Btn.Location = new System.Drawing.Point(1232, 408);
            this.AddUnitAbilitie_Btn.Name = "AddUnitAbilitie_Btn";
            this.AddUnitAbilitie_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddUnitAbilitie_Btn.TabIndex = 48;
            this.AddUnitAbilitie_Btn.Text = "Add New Ability";
            this.AddUnitAbilitie_Btn.UseVisualStyleBackColor = true;
            this.AddUnitAbilitie_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // AddUnitReplace_Btn
            // 
            this.AddUnitReplace_Btn.Location = new System.Drawing.Point(1157, 637);
            this.AddUnitReplace_Btn.Name = "AddUnitReplace_Btn";
            this.AddUnitReplace_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddUnitReplace_Btn.TabIndex = 47;
            this.AddUnitReplace_Btn.Text = "Add Unit to Replace";
            this.AddUnitReplace_Btn.UseVisualStyleBackColor = true;
            this.AddUnitReplace_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // AddUnit_Btn
            // 
            this.AddUnit_Btn.Location = new System.Drawing.Point(1041, 800);
            this.AddUnit_Btn.Name = "AddUnit_Btn";
            this.AddUnit_Btn.Size = new System.Drawing.Size(120, 23);
            this.AddUnit_Btn.TabIndex = 19;
            this.AddUnit_Btn.Text = "Add New Unit";
            this.AddUnit_Btn.UseVisualStyleBackColor = true;
            this.AddUnit_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_MainTables_Click);
            // 
            // AddUnit_BuildingPrereq_Btn
            // 
            this.AddUnit_BuildingPrereq_Btn.Location = new System.Drawing.Point(1070, 704);
            this.AddUnit_BuildingPrereq_Btn.Name = "AddUnit_BuildingPrereq_Btn";
            this.AddUnit_BuildingPrereq_Btn.Size = new System.Drawing.Size(130, 23);
            this.AddUnit_BuildingPrereq_Btn.TabIndex = 46;
            this.AddUnit_BuildingPrereq_Btn.Text = "Add Prereq Building";
            this.AddUnit_BuildingPrereq_Btn.UseVisualStyleBackColor = true;
            this.AddUnit_BuildingPrereq_Btn.Click += new System.EventHandler(this.AllAddObjectButtons_SecondaryTables_Click);
            // 
            // GridView_UnitAbilities
            // 
            this.GridView_UnitAbilities.AllowUserToAddRows = false;
            this.GridView_UnitAbilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitAbilities.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitAbilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitAbilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gridview_UnitAbilities_Col_UnitAbilityType,
            this.Gridview_UnitAbilities_Col_Name,
            this.Gridview_UnitAbilities_Col_Description,
            this.Gridview_UnitAbilities_Col_Inactive,
            this.Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned,
            this.Gridview_UnitAbilities_Col_Permanent});
            this.GridView_UnitAbilities.Location = new System.Drawing.Point(1232, 248);
            this.GridView_UnitAbilities.MultiSelect = false;
            this.GridView_UnitAbilities.Name = "GridView_UnitAbilities";
            this.GridView_UnitAbilities.RowHeadersVisible = false;
            this.GridView_UnitAbilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitAbilities.Size = new System.Drawing.Size(408, 154);
            this.GridView_UnitAbilities.TabIndex = 18;
            this.GridView_UnitAbilities.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_UnitAbilities.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_UnitAbilities_RowEnter);
            // 
            // Gridview_UnitAbilities_Col_UnitAbilityType
            // 
            this.Gridview_UnitAbilities_Col_UnitAbilityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gridview_UnitAbilities_Col_UnitAbilityType.HeaderText = "UnitAbilityType";
            this.Gridview_UnitAbilities_Col_UnitAbilityType.Name = "Gridview_UnitAbilities_Col_UnitAbilityType";
            this.Gridview_UnitAbilities_Col_UnitAbilityType.Width = 150;
            // 
            // Gridview_UnitAbilities_Col_Name
            // 
            this.Gridview_UnitAbilities_Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gridview_UnitAbilities_Col_Name.HeaderText = "Name";
            this.Gridview_UnitAbilities_Col_Name.MinimumWidth = 100;
            this.Gridview_UnitAbilities_Col_Name.Name = "Gridview_UnitAbilities_Col_Name";
            // 
            // Gridview_UnitAbilities_Col_Description
            // 
            this.Gridview_UnitAbilities_Col_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gridview_UnitAbilities_Col_Description.HeaderText = "Description";
            this.Gridview_UnitAbilities_Col_Description.Name = "Gridview_UnitAbilities_Col_Description";
            this.Gridview_UnitAbilities_Col_Description.Width = 150;
            // 
            // Gridview_UnitAbilities_Col_Inactive
            // 
            this.Gridview_UnitAbilities_Col_Inactive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gridview_UnitAbilities_Col_Inactive.HeaderText = "Inactive";
            this.Gridview_UnitAbilities_Col_Inactive.Name = "Gridview_UnitAbilities_Col_Inactive";
            this.Gridview_UnitAbilities_Col_Inactive.Width = 70;
            // 
            // Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned
            // 
            this.Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned.HeaderText = "ShowFloatTextWhenEarned";
            this.Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned.Name = "Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned";
            this.Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned.Width = 50;
            // 
            // Gridview_UnitAbilities_Col_Permanent
            // 
            this.Gridview_UnitAbilities_Col_Permanent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gridview_UnitAbilities_Col_Permanent.HeaderText = "Permanent";
            this.Gridview_UnitAbilities_Col_Permanent.Name = "Gridview_UnitAbilities_Col_Permanent";
            this.Gridview_UnitAbilities_Col_Permanent.Width = 83;
            // 
            // GridView_UnitTags
            // 
            this.GridView_UnitTags.AllowUserToAddRows = false;
            this.GridView_UnitTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitTags.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gridview_TypeTags_Col_Tag});
            this.GridView_UnitTags.Location = new System.Drawing.Point(1458, 422);
            this.GridView_UnitTags.MultiSelect = false;
            this.GridView_UnitTags.Name = "GridView_UnitTags";
            this.GridView_UnitTags.RowHeadersVisible = false;
            this.GridView_UnitTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitTags.Size = new System.Drawing.Size(185, 153);
            this.GridView_UnitTags.TabIndex = 16;
            this.GridView_UnitTags.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // Gridview_TypeTags_Col_Tag
            // 
            this.Gridview_TypeTags_Col_Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gridview_TypeTags_Col_Tag.HeaderText = "Tag";
            this.Gridview_TypeTags_Col_Tag.Name = "Gridview_TypeTags_Col_Tag";
            // 
            // GridView_UnitAiInfos
            // 
            this.GridView_UnitAiInfos.AllowUserToAddRows = false;
            this.GridView_UnitAiInfos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitAiInfos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitAiInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitAiInfos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gridview_UnitAiInfos_Col_AiType});
            this.GridView_UnitAiInfos.Location = new System.Drawing.Point(1455, 671);
            this.GridView_UnitAiInfos.MultiSelect = false;
            this.GridView_UnitAiInfos.Name = "GridView_UnitAiInfos";
            this.GridView_UnitAiInfos.RowHeadersVisible = false;
            this.GridView_UnitAiInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitAiInfos.Size = new System.Drawing.Size(185, 211);
            this.GridView_UnitAiInfos.TabIndex = 11;
            this.GridView_UnitAiInfos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // Gridview_UnitAiInfos_Col_AiType
            // 
            this.Gridview_UnitAiInfos_Col_AiType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gridview_UnitAiInfos_Col_AiType.HeaderText = "AiType";
            this.Gridview_UnitAiInfos_Col_AiType.Name = "Gridview_UnitAiInfos_Col_AiType";
            // 
            // GridView_Units
            // 
            this.GridView_Units.AllowUserToAddRows = false;
            this.GridView_Units.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Units.Location = new System.Drawing.Point(2, 771);
            this.GridView_Units.Margin = new System.Windows.Forms.Padding(2);
            this.GridView_Units.Name = "GridView_Units";
            this.GridView_Units.RowHeadersVisible = false;
            this.GridView_Units.RowTemplate.Height = 24;
            this.GridView_Units.Size = new System.Drawing.Size(1034, 124);
            this.GridView_Units.TabIndex = 14;
            this.GridView_Units.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_MainTables_CellMouseClick);
            this.GridView_Units.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview_Units_RowEnter);
            // 
            // GridView_UnitUpgrades
            // 
            this.GridView_UnitUpgrades.AllowUserToAddRows = false;
            this.GridView_UnitUpgrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitUpgrades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitUpgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitUpgrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gridview_UnitUpgrades_Col_UpgradeUnit});
            this.GridView_UnitUpgrades.Location = new System.Drawing.Point(1401, 554);
            this.GridView_UnitUpgrades.MultiSelect = false;
            this.GridView_UnitUpgrades.Name = "GridView_UnitUpgrades";
            this.GridView_UnitUpgrades.RowHeadersVisible = false;
            this.GridView_UnitUpgrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitUpgrades.Size = new System.Drawing.Size(239, 78);
            this.GridView_UnitUpgrades.TabIndex = 10;
            this.GridView_UnitUpgrades.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // Gridview_UnitUpgrades_Col_UpgradeUnit
            // 
            this.Gridview_UnitUpgrades_Col_UpgradeUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gridview_UnitUpgrades_Col_UpgradeUnit.HeaderText = "UpgradeUnit";
            this.Gridview_UnitUpgrades_Col_UpgradeUnit.Name = "Gridview_UnitUpgrades_Col_UpgradeUnit";
            // 
            // Panel_Table_Units
            // 
            this.Panel_Table_Units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.Panel_Table_Units.Controls.Add(this.tbx_Loc_Unit_Name);
            this.Panel_Table_Units.Controls.Add(this.groupBox1);
            this.Panel_Table_Units.Controls.Add(this.tbx_Loc_Unit_Description);
            this.Panel_Table_Units.Controls.Add(this.groupBox8);
            this.Panel_Table_Units.Controls.Add(this.groupBox7);
            this.Panel_Table_Units.Controls.Add(this.groupBox6);
            this.Panel_Table_Units.Controls.Add(this.groupBox5);
            this.Panel_Table_Units.Controls.Add(this.groupBox4);
            this.Panel_Table_Units.Controls.Add(this.groupBox3);
            this.Panel_Table_Units.Controls.Add(this.groupBox2);
            this.Panel_Table_Units.Controls.Add(this.CurrentUnit_Label);
            this.Panel_Table_Units.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_Table_Units.Location = new System.Drawing.Point(2, 2);
            this.Panel_Table_Units.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Table_Units.Name = "Panel_Table_Units";
            this.Panel_Table_Units.Size = new System.Drawing.Size(1034, 765);
            this.Panel_Table_Units.TabIndex = 13;
            // 
            // tbx_Loc_Unit_Name
            // 
            this.tbx_Loc_Unit_Name.BackAlpha = 10;
            this.tbx_Loc_Unit_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.tbx_Loc_Unit_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Loc_Unit_Name.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Loc_Unit_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Loc_Unit_Name.Location = new System.Drawing.Point(280, 3);
            this.tbx_Loc_Unit_Name.Multiline = true;
            this.tbx_Loc_Unit_Name.Name = "tbx_Loc_Unit_Name";
            this.tbx_Loc_Unit_Name.Size = new System.Drawing.Size(360, 32);
            this.tbx_Loc_Unit_Name.TabIndex = 153;
            this.tbx_Loc_Unit_Name.Text = "Unit Name";
            this.tbx_Loc_Unit_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_Unit_Maintenance);
            this.groupBox1.Controls.Add(this.cbx_Unit_XP2_ResourceMaintenanceType);
            this.groupBox1.Controls.Add(this.tbx_Unit_Maintenance);
            this.groupBox1.Controls.Add(this.tbx_Unit_XP2_ResourceMaintenanceAmount);
            this.groupBox1.Controls.Add(this.pic_Unit_XP2_ResourceMaintenanceType);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(642, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 96);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance:";
            // 
            // pic_Unit_Maintenance
            // 
            this.pic_Unit_Maintenance.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Maintenance.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Maintenance.Image")));
            this.pic_Unit_Maintenance.Location = new System.Drawing.Point(6, 27);
            this.pic_Unit_Maintenance.Name = "pic_Unit_Maintenance";
            this.pic_Unit_Maintenance.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_Maintenance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_Maintenance.TabIndex = 136;
            this.pic_Unit_Maintenance.TabStop = false;
            // 
            // cbx_Unit_XP2_ResourceMaintenanceType
            // 
            this.cbx_Unit_XP2_ResourceMaintenanceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_XP2_ResourceMaintenanceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_XP2_ResourceMaintenanceType.DropDownWidth = 267;
            this.cbx_Unit_XP2_ResourceMaintenanceType.Location = new System.Drawing.Point(41, 65);
            this.cbx_Unit_XP2_ResourceMaintenanceType.Name = "cbx_Unit_XP2_ResourceMaintenanceType";
            this.cbx_Unit_XP2_ResourceMaintenanceType.Size = new System.Drawing.Size(284, 23);
            this.cbx_Unit_XP2_ResourceMaintenanceType.Sorted = true;
            this.cbx_Unit_XP2_ResourceMaintenanceType.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_XP2_ResourceMaintenanceType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_XP2_ResourceMaintenanceType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_XP2_ResourceMaintenanceType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_XP2_ResourceMaintenanceType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_XP2_ResourceMaintenanceType.TabIndex = 147;
            this.cbx_Unit_XP2_ResourceMaintenanceType.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // tbx_Unit_Maintenance
            // 
            this.tbx_Unit_Maintenance.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Maintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_Maintenance.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_Maintenance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_Maintenance.Location = new System.Drawing.Point(43, 28);
            this.tbx_Unit_Maintenance.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_Maintenance.Name = "tbx_Unit_Maintenance";
            this.tbx_Unit_Maintenance.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_Maintenance.TabIndex = 120;
            this.tbx_Unit_Maintenance.WordWrap = false;
            // 
            // tbx_Unit_XP2_ResourceMaintenanceAmount
            // 
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.Location = new System.Drawing.Point(325, 63);
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.Name = "tbx_Unit_XP2_ResourceMaintenanceAmount";
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.TabIndex = 134;
            this.tbx_Unit_XP2_ResourceMaintenanceAmount.WordWrap = false;
            // 
            // pic_Unit_XP2_ResourceMaintenanceType
            // 
            this.pic_Unit_XP2_ResourceMaintenanceType.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_XP2_ResourceMaintenanceType.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_XP2_ResourceMaintenanceType.Image")));
            this.pic_Unit_XP2_ResourceMaintenanceType.Location = new System.Drawing.Point(6, 59);
            this.pic_Unit_XP2_ResourceMaintenanceType.Name = "pic_Unit_XP2_ResourceMaintenanceType";
            this.pic_Unit_XP2_ResourceMaintenanceType.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_XP2_ResourceMaintenanceType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_XP2_ResourceMaintenanceType.TabIndex = 137;
            this.pic_Unit_XP2_ResourceMaintenanceType.TabStop = false;
            // 
            // tbx_Loc_Unit_Description
            // 
            this.tbx_Loc_Unit_Description.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Loc_Unit_Description.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Loc_Unit_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Loc_Unit_Description.Location = new System.Drawing.Point(280, 45);
            this.tbx_Loc_Unit_Description.Name = "tbx_Loc_Unit_Description";
            this.tbx_Loc_Unit_Description.Size = new System.Drawing.Size(358, 183);
            this.tbx_Loc_Unit_Description.TabIndex = 144;
            this.tbx_Loc_Unit_Description.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chbx_Unit_Spy);
            this.groupBox8.Controls.Add(this.chbx_Unit_TeamVisibility);
            this.groupBox8.Controls.Add(this.pic_Unit_TraitType);
            this.groupBox8.Controls.Add(this.cbx_Unit_PseudoYieldType);
            this.groupBox8.Controls.Add(this.pic_Unit_NumRandomChoices);
            this.groupBox8.Controls.Add(this.tbx_Unit_TraitType);
            this.groupBox8.Controls.Add(this.tbx_Unit_NumRandomChoices);
            this.groupBox8.Controls.Add(this.cbx_Unit_AdvisorType);
            this.groupBox8.Controls.Add(this.cbx_Unit_LeaderType);
            this.groupBox8.Controls.Add(this.chbx_Unit_FoundCity);
            this.groupBox8.Controls.Add(this.chbx_Unit_MakeTradeRoute);
            this.groupBox8.Controls.Add(this.chbx_Unit_ExtractsArtifacts);
            this.groupBox8.Controls.Add(this.tbx_Unit_DisasterCharges);
            this.groupBox8.Controls.Add(this.chbx_Unit_ImmediatelyName);
            this.groupBox8.Controls.Add(this.chbx_Unit_XP2_MajorCivOnly);
            this.groupBox8.Controls.Add(this.pic_Unit_LeaderType);
            this.groupBox8.Controls.Add(this.pic_Unit_PseudoYieldType);
            this.groupBox8.Controls.Add(this.chbx_Unit_Stackable);
            this.groupBox8.Controls.Add(this.chbx_Unit_AllowBarbarians);
            this.groupBox8.Controls.Add(this.chbx_Unit_XP2_CanCauseDisasters);
            this.groupBox8.Controls.Add(this.chbx_Unit_IgnoreMoves);
            this.groupBox8.Controls.Add(this.tbx_Unit_BuildCharges);
            this.groupBox8.Controls.Add(this.tbx_Unit_XP2_TourismBomb);
            this.groupBox8.Controls.Add(this.pic_Unit_AdvisorType);
            this.groupBox8.Controls.Add(this.chbx_Unit_XP2_CanSacrificeUnits);
            this.groupBox8.Controls.Add(this.pic_Unit_BuildCharges);
            this.groupBox8.Controls.Add(this.chbx_Unit_XP2_TourismBombPossible);
            this.groupBox8.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox8.Location = new System.Drawing.Point(6, 517);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(632, 229);
            this.groupBox8.TabIndex = 142;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Other:";
            // 
            // chbx_Unit_Spy
            // 
            this.chbx_Unit_Spy.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_Spy.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_Spy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_Spy.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_Spy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_Spy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_Spy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_Spy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_Spy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_Spy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_Spy.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_Spy.Image")));
            this.chbx_Unit_Spy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_Spy.Location = new System.Drawing.Point(520, 126);
            this.chbx_Unit_Spy.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_Spy.Name = "chbx_Unit_Spy";
            this.chbx_Unit_Spy.Size = new System.Drawing.Size(102, 27);
            this.chbx_Unit_Spy.TabIndex = 86;
            this.chbx_Unit_Spy.Text = "Spy";
            this.chbx_Unit_Spy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_Spy.UseVisualStyleBackColor = true;
            this.chbx_Unit_Spy.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_TeamVisibility
            // 
            this.chbx_Unit_TeamVisibility.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_TeamVisibility.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_TeamVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_TeamVisibility.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_TeamVisibility.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_TeamVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_TeamVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_TeamVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_TeamVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_TeamVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_TeamVisibility.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_TeamVisibility.Image")));
            this.chbx_Unit_TeamVisibility.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_TeamVisibility.Location = new System.Drawing.Point(241, 158);
            this.chbx_Unit_TeamVisibility.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_TeamVisibility.Name = "chbx_Unit_TeamVisibility";
            this.chbx_Unit_TeamVisibility.Size = new System.Drawing.Size(127, 27);
            this.chbx_Unit_TeamVisibility.TabIndex = 91;
            this.chbx_Unit_TeamVisibility.Text = "TeamVisibility";
            this.chbx_Unit_TeamVisibility.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_TeamVisibility.UseVisualStyleBackColor = true;
            this.chbx_Unit_TeamVisibility.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // pic_Unit_TraitType
            // 
            this.pic_Unit_TraitType.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_TraitType.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_TraitType.Image")));
            this.pic_Unit_TraitType.Location = new System.Drawing.Point(0, 60);
            this.pic_Unit_TraitType.Name = "pic_Unit_TraitType";
            this.pic_Unit_TraitType.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_TraitType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_TraitType.TabIndex = 150;
            this.pic_Unit_TraitType.TabStop = false;
            // 
            // cbx_Unit_PseudoYieldType
            // 
            this.cbx_Unit_PseudoYieldType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_PseudoYieldType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_PseudoYieldType.DropDownWidth = 267;
            this.cbx_Unit_PseudoYieldType.Location = new System.Drawing.Point(35, 130);
            this.cbx_Unit_PseudoYieldType.Name = "cbx_Unit_PseudoYieldType";
            this.cbx_Unit_PseudoYieldType.Size = new System.Drawing.Size(347, 23);
            this.cbx_Unit_PseudoYieldType.Sorted = true;
            this.cbx_Unit_PseudoYieldType.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PseudoYieldType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PseudoYieldType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_PseudoYieldType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_PseudoYieldType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_PseudoYieldType.TabIndex = 149;
            this.cbx_Unit_PseudoYieldType.DropDown += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_NumRandomChoices
            // 
            this.pic_Unit_NumRandomChoices.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_NumRandomChoices.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_NumRandomChoices.Image")));
            this.pic_Unit_NumRandomChoices.Location = new System.Drawing.Point(522, 24);
            this.pic_Unit_NumRandomChoices.Name = "pic_Unit_NumRandomChoices";
            this.pic_Unit_NumRandomChoices.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_NumRandomChoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_NumRandomChoices.TabIndex = 149;
            this.pic_Unit_NumRandomChoices.TabStop = false;
            // 
            // tbx_Unit_TraitType
            // 
            this.tbx_Unit_TraitType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbx_Unit_TraitType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbx_Unit_TraitType.DropDownWidth = 267;
            this.tbx_Unit_TraitType.Location = new System.Drawing.Point(35, 64);
            this.tbx_Unit_TraitType.Name = "tbx_Unit_TraitType";
            this.tbx_Unit_TraitType.Size = new System.Drawing.Size(347, 23);
            this.tbx_Unit_TraitType.Sorted = true;
            this.tbx_Unit_TraitType.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_TraitType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_TraitType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbx_Unit_TraitType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Unit_TraitType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_TraitType.TabIndex = 147;
            this.tbx_Unit_TraitType.DropDown += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // tbx_Unit_NumRandomChoices
            // 
            this.tbx_Unit_NumRandomChoices.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_NumRandomChoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_NumRandomChoices.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_NumRandomChoices.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_NumRandomChoices.Location = new System.Drawing.Point(559, 24);
            this.tbx_Unit_NumRandomChoices.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_NumRandomChoices.Name = "tbx_Unit_NumRandomChoices";
            this.tbx_Unit_NumRandomChoices.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_NumRandomChoices.TabIndex = 145;
            this.tbx_Unit_NumRandomChoices.WordWrap = false;
            // 
            // cbx_Unit_AdvisorType
            // 
            this.cbx_Unit_AdvisorType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_AdvisorType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_AdvisorType.DropDownWidth = 267;
            this.cbx_Unit_AdvisorType.Location = new System.Drawing.Point(35, 97);
            this.cbx_Unit_AdvisorType.Name = "cbx_Unit_AdvisorType";
            this.cbx_Unit_AdvisorType.Size = new System.Drawing.Size(347, 23);
            this.cbx_Unit_AdvisorType.Sorted = true;
            this.cbx_Unit_AdvisorType.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_AdvisorType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_AdvisorType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_AdvisorType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_AdvisorType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_AdvisorType.TabIndex = 148;
            this.cbx_Unit_AdvisorType.DropDown += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_LeaderType
            // 
            this.cbx_Unit_LeaderType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_LeaderType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_LeaderType.DropDownWidth = 267;
            this.cbx_Unit_LeaderType.Location = new System.Drawing.Point(35, 31);
            this.cbx_Unit_LeaderType.Name = "cbx_Unit_LeaderType";
            this.cbx_Unit_LeaderType.Size = new System.Drawing.Size(347, 23);
            this.cbx_Unit_LeaderType.Sorted = true;
            this.cbx_Unit_LeaderType.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_LeaderType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_LeaderType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_LeaderType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_LeaderType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_LeaderType.TabIndex = 147;
            this.cbx_Unit_LeaderType.DropDown += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // chbx_Unit_FoundCity
            // 
            this.chbx_Unit_FoundCity.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_FoundCity.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_FoundCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_FoundCity.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_FoundCity.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_FoundCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_FoundCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_FoundCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_FoundCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_FoundCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_FoundCity.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_FoundCity.Image")));
            this.chbx_Unit_FoundCity.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_FoundCity.Location = new System.Drawing.Point(385, 62);
            this.chbx_Unit_FoundCity.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_FoundCity.Name = "chbx_Unit_FoundCity";
            this.chbx_Unit_FoundCity.Size = new System.Drawing.Size(109, 27);
            this.chbx_Unit_FoundCity.TabIndex = 54;
            this.chbx_Unit_FoundCity.Text = "FoundCity";
            this.chbx_Unit_FoundCity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_FoundCity.UseVisualStyleBackColor = true;
            this.chbx_Unit_FoundCity.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_MakeTradeRoute
            // 
            this.chbx_Unit_MakeTradeRoute.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_MakeTradeRoute.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_MakeTradeRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_MakeTradeRoute.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_MakeTradeRoute.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_MakeTradeRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_MakeTradeRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_MakeTradeRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_MakeTradeRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_MakeTradeRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_MakeTradeRoute.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_MakeTradeRoute.Image")));
            this.chbx_Unit_MakeTradeRoute.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_MakeTradeRoute.Location = new System.Drawing.Point(385, 126);
            this.chbx_Unit_MakeTradeRoute.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_MakeTradeRoute.Name = "chbx_Unit_MakeTradeRoute";
            this.chbx_Unit_MakeTradeRoute.Size = new System.Drawing.Size(144, 27);
            this.chbx_Unit_MakeTradeRoute.TabIndex = 74;
            this.chbx_Unit_MakeTradeRoute.Text = "MakeTradeRoute";
            this.chbx_Unit_MakeTradeRoute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_MakeTradeRoute.UseVisualStyleBackColor = true;
            this.chbx_Unit_MakeTradeRoute.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_ExtractsArtifacts
            // 
            this.chbx_Unit_ExtractsArtifacts.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_ExtractsArtifacts.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_ExtractsArtifacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_ExtractsArtifacts.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_ExtractsArtifacts.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_ExtractsArtifacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_ExtractsArtifacts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_ExtractsArtifacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_ExtractsArtifacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_ExtractsArtifacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_ExtractsArtifacts.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_ExtractsArtifacts.Image")));
            this.chbx_Unit_ExtractsArtifacts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_ExtractsArtifacts.Location = new System.Drawing.Point(385, 185);
            this.chbx_Unit_ExtractsArtifacts.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_ExtractsArtifacts.Name = "chbx_Unit_ExtractsArtifacts";
            this.chbx_Unit_ExtractsArtifacts.Size = new System.Drawing.Size(138, 27);
            this.chbx_Unit_ExtractsArtifacts.TabIndex = 78;
            this.chbx_Unit_ExtractsArtifacts.Text = "ExtractsArtifacts";
            this.chbx_Unit_ExtractsArtifacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_ExtractsArtifacts.UseVisualStyleBackColor = true;
            this.chbx_Unit_ExtractsArtifacts.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Unit_DisasterCharges
            // 
            this.tbx_Unit_DisasterCharges.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_DisasterCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_DisasterCharges.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_DisasterCharges.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_DisasterCharges.Location = new System.Drawing.Point(181, 188);
            this.tbx_Unit_DisasterCharges.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_DisasterCharges.Name = "tbx_Unit_DisasterCharges";
            this.tbx_Unit_DisasterCharges.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_DisasterCharges.TabIndex = 115;
            this.tbx_Unit_DisasterCharges.WordWrap = false;
            // 
            // chbx_Unit_ImmediatelyName
            // 
            this.chbx_Unit_ImmediatelyName.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_ImmediatelyName.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_ImmediatelyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_ImmediatelyName.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_ImmediatelyName.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_ImmediatelyName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_ImmediatelyName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_ImmediatelyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_ImmediatelyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_ImmediatelyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_ImmediatelyName.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_ImmediatelyName.Image")));
            this.chbx_Unit_ImmediatelyName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_ImmediatelyName.Location = new System.Drawing.Point(241, 186);
            this.chbx_Unit_ImmediatelyName.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_ImmediatelyName.Name = "chbx_Unit_ImmediatelyName";
            this.chbx_Unit_ImmediatelyName.Size = new System.Drawing.Size(146, 27);
            this.chbx_Unit_ImmediatelyName.TabIndex = 94;
            this.chbx_Unit_ImmediatelyName.Text = "ImmediatelyName";
            this.chbx_Unit_ImmediatelyName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_ImmediatelyName.UseVisualStyleBackColor = true;
            this.chbx_Unit_ImmediatelyName.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_XP2_MajorCivOnly
            // 
            this.chbx_Unit_XP2_MajorCivOnly.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_XP2_MajorCivOnly.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_MajorCivOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_XP2_MajorCivOnly.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_XP2_MajorCivOnly.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_MajorCivOnly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_XP2_MajorCivOnly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_XP2_MajorCivOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_XP2_MajorCivOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_XP2_MajorCivOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_XP2_MajorCivOnly.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_XP2_MajorCivOnly.Image")));
            this.chbx_Unit_XP2_MajorCivOnly.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_XP2_MajorCivOnly.Location = new System.Drawing.Point(520, 158);
            this.chbx_Unit_XP2_MajorCivOnly.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_XP2_MajorCivOnly.Name = "chbx_Unit_XP2_MajorCivOnly";
            this.chbx_Unit_XP2_MajorCivOnly.Size = new System.Drawing.Size(138, 27);
            this.chbx_Unit_XP2_MajorCivOnly.TabIndex = 138;
            this.chbx_Unit_XP2_MajorCivOnly.Text = "MajorCivOnly";
            this.chbx_Unit_XP2_MajorCivOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_XP2_MajorCivOnly.UseVisualStyleBackColor = true;
            this.chbx_Unit_XP2_MajorCivOnly.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // pic_Unit_LeaderType
            // 
            this.pic_Unit_LeaderType.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_LeaderType.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_LeaderType.Image")));
            this.pic_Unit_LeaderType.Location = new System.Drawing.Point(0, 24);
            this.pic_Unit_LeaderType.Name = "pic_Unit_LeaderType";
            this.pic_Unit_LeaderType.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_LeaderType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_LeaderType.TabIndex = 142;
            this.pic_Unit_LeaderType.TabStop = false;
            // 
            // pic_Unit_PseudoYieldType
            // 
            this.pic_Unit_PseudoYieldType.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PseudoYieldType.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PseudoYieldType.Image")));
            this.pic_Unit_PseudoYieldType.Location = new System.Drawing.Point(0, 126);
            this.pic_Unit_PseudoYieldType.Name = "pic_Unit_PseudoYieldType";
            this.pic_Unit_PseudoYieldType.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PseudoYieldType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PseudoYieldType.TabIndex = 139;
            this.pic_Unit_PseudoYieldType.TabStop = false;
            // 
            // chbx_Unit_Stackable
            // 
            this.chbx_Unit_Stackable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_Stackable.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_Stackable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_Stackable.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_Stackable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_Stackable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_Stackable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_Stackable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_Stackable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_Stackable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_Stackable.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_Stackable.Image")));
            this.chbx_Unit_Stackable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_Stackable.Location = new System.Drawing.Point(520, 62);
            this.chbx_Unit_Stackable.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_Stackable.Name = "chbx_Unit_Stackable";
            this.chbx_Unit_Stackable.Size = new System.Drawing.Size(109, 27);
            this.chbx_Unit_Stackable.TabIndex = 83;
            this.chbx_Unit_Stackable.Text = "Stackable";
            this.chbx_Unit_Stackable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_Stackable.UseVisualStyleBackColor = true;
            this.chbx_Unit_Stackable.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_AllowBarbarians
            // 
            this.chbx_Unit_AllowBarbarians.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_AllowBarbarians.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_AllowBarbarians.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_AllowBarbarians.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_AllowBarbarians.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_AllowBarbarians.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_AllowBarbarians.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_AllowBarbarians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_AllowBarbarians.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_AllowBarbarians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_AllowBarbarians.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_AllowBarbarians.Image")));
            this.chbx_Unit_AllowBarbarians.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_AllowBarbarians.Location = new System.Drawing.Point(385, 94);
            this.chbx_Unit_AllowBarbarians.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_AllowBarbarians.Name = "chbx_Unit_AllowBarbarians";
            this.chbx_Unit_AllowBarbarians.Size = new System.Drawing.Size(138, 27);
            this.chbx_Unit_AllowBarbarians.TabIndex = 81;
            this.chbx_Unit_AllowBarbarians.Text = "AllowBarbarians";
            this.chbx_Unit_AllowBarbarians.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_AllowBarbarians.UseVisualStyleBackColor = true;
            this.chbx_Unit_AllowBarbarians.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_XP2_CanCauseDisasters
            // 
            this.chbx_Unit_XP2_CanCauseDisasters.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_XP2_CanCauseDisasters.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanCauseDisasters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_XP2_CanCauseDisasters.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_XP2_CanCauseDisasters.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanCauseDisasters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_XP2_CanCauseDisasters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_XP2_CanCauseDisasters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_XP2_CanCauseDisasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_XP2_CanCauseDisasters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_XP2_CanCauseDisasters.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_XP2_CanCauseDisasters.Image")));
            this.chbx_Unit_XP2_CanCauseDisasters.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_XP2_CanCauseDisasters.Location = new System.Drawing.Point(3, 188);
            this.chbx_Unit_XP2_CanCauseDisasters.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_XP2_CanCauseDisasters.Name = "chbx_Unit_XP2_CanCauseDisasters";
            this.chbx_Unit_XP2_CanCauseDisasters.Size = new System.Drawing.Size(153, 22);
            this.chbx_Unit_XP2_CanCauseDisasters.TabIndex = 139;
            this.chbx_Unit_XP2_CanCauseDisasters.Text = "CanCauseDisasters";
            this.chbx_Unit_XP2_CanCauseDisasters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_XP2_CanCauseDisasters.UseVisualStyleBackColor = true;
            this.chbx_Unit_XP2_CanCauseDisasters.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_IgnoreMoves
            // 
            this.chbx_Unit_IgnoreMoves.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_IgnoreMoves.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_IgnoreMoves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_IgnoreMoves.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_IgnoreMoves.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_IgnoreMoves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_IgnoreMoves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_IgnoreMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_IgnoreMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_IgnoreMoves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_IgnoreMoves.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_IgnoreMoves.Image")));
            this.chbx_Unit_IgnoreMoves.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_IgnoreMoves.Location = new System.Drawing.Point(520, 97);
            this.chbx_Unit_IgnoreMoves.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_IgnoreMoves.Name = "chbx_Unit_IgnoreMoves";
            this.chbx_Unit_IgnoreMoves.Size = new System.Drawing.Size(109, 27);
            this.chbx_Unit_IgnoreMoves.TabIndex = 90;
            this.chbx_Unit_IgnoreMoves.Text = "IgnoreMoves";
            this.chbx_Unit_IgnoreMoves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_IgnoreMoves.UseVisualStyleBackColor = true;
            this.chbx_Unit_IgnoreMoves.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Unit_BuildCharges
            // 
            this.tbx_Unit_BuildCharges.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_BuildCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_BuildCharges.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_BuildCharges.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_BuildCharges.Location = new System.Drawing.Point(422, 27);
            this.tbx_Unit_BuildCharges.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_BuildCharges.Name = "tbx_Unit_BuildCharges";
            this.tbx_Unit_BuildCharges.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_BuildCharges.TabIndex = 105;
            this.tbx_Unit_BuildCharges.WordWrap = false;
            // 
            // tbx_Unit_XP2_TourismBomb
            // 
            this.tbx_Unit_XP2_TourismBomb.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_XP2_TourismBomb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_XP2_TourismBomb.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_XP2_TourismBomb.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_XP2_TourismBomb.Location = new System.Drawing.Point(181, 161);
            this.tbx_Unit_XP2_TourismBomb.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_XP2_TourismBomb.Name = "tbx_Unit_XP2_TourismBomb";
            this.tbx_Unit_XP2_TourismBomb.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_XP2_TourismBomb.TabIndex = 141;
            this.tbx_Unit_XP2_TourismBomb.WordWrap = false;
            // 
            // pic_Unit_AdvisorType
            // 
            this.pic_Unit_AdvisorType.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_AdvisorType.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_AdvisorType.Image")));
            this.pic_Unit_AdvisorType.Location = new System.Drawing.Point(0, 92);
            this.pic_Unit_AdvisorType.Name = "pic_Unit_AdvisorType";
            this.pic_Unit_AdvisorType.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_AdvisorType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_AdvisorType.TabIndex = 143;
            this.pic_Unit_AdvisorType.TabStop = false;
            // 
            // chbx_Unit_XP2_CanSacrificeUnits
            // 
            this.chbx_Unit_XP2_CanSacrificeUnits.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_XP2_CanSacrificeUnits.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanSacrificeUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_XP2_CanSacrificeUnits.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_XP2_CanSacrificeUnits.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanSacrificeUnits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_XP2_CanSacrificeUnits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_XP2_CanSacrificeUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_XP2_CanSacrificeUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_XP2_CanSacrificeUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_XP2_CanSacrificeUnits.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_XP2_CanSacrificeUnits.Image")));
            this.chbx_Unit_XP2_CanSacrificeUnits.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_XP2_CanSacrificeUnits.Location = new System.Drawing.Point(385, 158);
            this.chbx_Unit_XP2_CanSacrificeUnits.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_XP2_CanSacrificeUnits.Name = "chbx_Unit_XP2_CanSacrificeUnits";
            this.chbx_Unit_XP2_CanSacrificeUnits.Size = new System.Drawing.Size(146, 22);
            this.chbx_Unit_XP2_CanSacrificeUnits.TabIndex = 140;
            this.chbx_Unit_XP2_CanSacrificeUnits.Text = "CanSacrificeUnits";
            this.chbx_Unit_XP2_CanSacrificeUnits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_XP2_CanSacrificeUnits.UseVisualStyleBackColor = true;
            this.chbx_Unit_XP2_CanSacrificeUnits.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // pic_Unit_BuildCharges
            // 
            this.pic_Unit_BuildCharges.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_BuildCharges.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_BuildCharges.Image")));
            this.pic_Unit_BuildCharges.Location = new System.Drawing.Point(385, 27);
            this.pic_Unit_BuildCharges.Name = "pic_Unit_BuildCharges";
            this.pic_Unit_BuildCharges.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_BuildCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_BuildCharges.TabIndex = 110;
            this.pic_Unit_BuildCharges.TabStop = false;
            // 
            // chbx_Unit_XP2_TourismBombPossible
            // 
            this.chbx_Unit_XP2_TourismBombPossible.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_XP2_TourismBombPossible.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_TourismBombPossible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_XP2_TourismBombPossible.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_XP2_TourismBombPossible.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_TourismBombPossible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_XP2_TourismBombPossible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_XP2_TourismBombPossible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_XP2_TourismBombPossible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_XP2_TourismBombPossible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_XP2_TourismBombPossible.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_XP2_TourismBombPossible.Image")));
            this.chbx_Unit_XP2_TourismBombPossible.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_XP2_TourismBombPossible.Location = new System.Drawing.Point(3, 161);
            this.chbx_Unit_XP2_TourismBombPossible.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_XP2_TourismBombPossible.Name = "chbx_Unit_XP2_TourismBombPossible";
            this.chbx_Unit_XP2_TourismBombPossible.Size = new System.Drawing.Size(177, 27);
            this.chbx_Unit_XP2_TourismBombPossible.TabIndex = 137;
            this.chbx_Unit_XP2_TourismBombPossible.Text = "TourismBombPossible";
            this.chbx_Unit_XP2_TourismBombPossible.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_XP2_TourismBombPossible.UseVisualStyleBackColor = true;
            this.chbx_Unit_XP2_TourismBombPossible.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbx_Unit_MandatoryObsoleteCivic);
            this.groupBox7.Controls.Add(this.cbx_Unit_MandatoryObsoleteTech);
            this.groupBox7.Controls.Add(this.pic_Unit_MandatoryObsoleteCivic);
            this.groupBox7.Controls.Add(this.pic_Unit_MandatoryObsoleteTech);
            this.groupBox7.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox7.Location = new System.Drawing.Point(643, 561);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(373, 98);
            this.groupBox7.TabIndex = 120;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mandatory Obsolete:";
            // 
            // cbx_Unit_MandatoryObsoleteCivic
            // 
            this.cbx_Unit_MandatoryObsoleteCivic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_MandatoryObsoleteCivic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_MandatoryObsoleteCivic.DropDownWidth = 267;
            this.cbx_Unit_MandatoryObsoleteCivic.Location = new System.Drawing.Point(44, 67);
            this.cbx_Unit_MandatoryObsoleteCivic.Name = "cbx_Unit_MandatoryObsoleteCivic";
            this.cbx_Unit_MandatoryObsoleteCivic.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_MandatoryObsoleteCivic.Sorted = true;
            this.cbx_Unit_MandatoryObsoleteCivic.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_MandatoryObsoleteCivic.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_MandatoryObsoleteCivic.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_MandatoryObsoleteCivic.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_MandatoryObsoleteCivic.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_MandatoryObsoleteCivic.TabIndex = 111;
            this.cbx_Unit_MandatoryObsoleteCivic.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_MandatoryObsoleteTech
            // 
            this.cbx_Unit_MandatoryObsoleteTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_MandatoryObsoleteTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_MandatoryObsoleteTech.DropDownWidth = 267;
            this.cbx_Unit_MandatoryObsoleteTech.Location = new System.Drawing.Point(44, 29);
            this.cbx_Unit_MandatoryObsoleteTech.Name = "cbx_Unit_MandatoryObsoleteTech";
            this.cbx_Unit_MandatoryObsoleteTech.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_MandatoryObsoleteTech.Sorted = true;
            this.cbx_Unit_MandatoryObsoleteTech.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_MandatoryObsoleteTech.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_MandatoryObsoleteTech.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_MandatoryObsoleteTech.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_MandatoryObsoleteTech.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_MandatoryObsoleteTech.TabIndex = 110;
            this.cbx_Unit_MandatoryObsoleteTech.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_MandatoryObsoleteCivic
            // 
            this.pic_Unit_MandatoryObsoleteCivic.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_MandatoryObsoleteCivic.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_MandatoryObsoleteCivic.Image")));
            this.pic_Unit_MandatoryObsoleteCivic.Location = new System.Drawing.Point(6, 61);
            this.pic_Unit_MandatoryObsoleteCivic.Name = "pic_Unit_MandatoryObsoleteCivic";
            this.pic_Unit_MandatoryObsoleteCivic.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_MandatoryObsoleteCivic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_MandatoryObsoleteCivic.TabIndex = 104;
            this.pic_Unit_MandatoryObsoleteCivic.TabStop = false;
            // 
            // pic_Unit_MandatoryObsoleteTech
            // 
            this.pic_Unit_MandatoryObsoleteTech.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_MandatoryObsoleteTech.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_MandatoryObsoleteTech.Image")));
            this.pic_Unit_MandatoryObsoleteTech.Location = new System.Drawing.Point(6, 24);
            this.pic_Unit_MandatoryObsoleteTech.Name = "pic_Unit_MandatoryObsoleteTech";
            this.pic_Unit_MandatoryObsoleteTech.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_MandatoryObsoleteTech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_MandatoryObsoleteTech.TabIndex = 103;
            this.pic_Unit_MandatoryObsoleteTech.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbx_Unit_ObsoleteCivic);
            this.groupBox6.Controls.Add(this.cbx_Unit_ObsoleteTech);
            this.groupBox6.Controls.Add(this.pic_Unit_ObsoleteTech);
            this.groupBox6.Controls.Add(this.pic_Unit_ObsoleteCivic);
            this.groupBox6.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox6.Location = new System.Drawing.Point(642, 463);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 98);
            this.groupBox6.TabIndex = 119;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Obsolete:";
            // 
            // cbx_Unit_ObsoleteCivic
            // 
            this.cbx_Unit_ObsoleteCivic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_ObsoleteCivic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_ObsoleteCivic.DropDownWidth = 267;
            this.cbx_Unit_ObsoleteCivic.Location = new System.Drawing.Point(44, 66);
            this.cbx_Unit_ObsoleteCivic.Name = "cbx_Unit_ObsoleteCivic";
            this.cbx_Unit_ObsoleteCivic.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_ObsoleteCivic.Sorted = true;
            this.cbx_Unit_ObsoleteCivic.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_ObsoleteCivic.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_ObsoleteCivic.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_ObsoleteCivic.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_ObsoleteCivic.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_ObsoleteCivic.TabIndex = 109;
            this.cbx_Unit_ObsoleteCivic.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_ObsoleteTech
            // 
            this.cbx_Unit_ObsoleteTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_ObsoleteTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_ObsoleteTech.DropDownWidth = 267;
            this.cbx_Unit_ObsoleteTech.Location = new System.Drawing.Point(44, 30);
            this.cbx_Unit_ObsoleteTech.Name = "cbx_Unit_ObsoleteTech";
            this.cbx_Unit_ObsoleteTech.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_ObsoleteTech.Sorted = true;
            this.cbx_Unit_ObsoleteTech.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_ObsoleteTech.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_ObsoleteTech.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_ObsoleteTech.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_ObsoleteTech.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_ObsoleteTech.TabIndex = 108;
            this.cbx_Unit_ObsoleteTech.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_ObsoleteTech
            // 
            this.pic_Unit_ObsoleteTech.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_ObsoleteTech.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_ObsoleteTech.Image")));
            this.pic_Unit_ObsoleteTech.Location = new System.Drawing.Point(5, 22);
            this.pic_Unit_ObsoleteTech.Name = "pic_Unit_ObsoleteTech";
            this.pic_Unit_ObsoleteTech.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_ObsoleteTech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_ObsoleteTech.TabIndex = 101;
            this.pic_Unit_ObsoleteTech.TabStop = false;
            // 
            // pic_Unit_ObsoleteCivic
            // 
            this.pic_Unit_ObsoleteCivic.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_ObsoleteCivic.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_ObsoleteCivic.Image")));
            this.pic_Unit_ObsoleteCivic.Location = new System.Drawing.Point(5, 60);
            this.pic_Unit_ObsoleteCivic.Name = "pic_Unit_ObsoleteCivic";
            this.pic_Unit_ObsoleteCivic.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_ObsoleteCivic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_ObsoleteCivic.TabIndex = 102;
            this.pic_Unit_ObsoleteCivic.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbx_Unit_PrereqDistrict);
            this.groupBox5.Controls.Add(this.cbx_Unit_PrereqCivic);
            this.groupBox5.Controls.Add(this.cbx_Unit_PrereqTech);
            this.groupBox5.Controls.Add(this.pic_Unit_PrereqTech);
            this.groupBox5.Controls.Add(this.tbx_Unit_PrereqPopulation);
            this.groupBox5.Controls.Add(this.pic_Unit_PrereqCivic);
            this.groupBox5.Controls.Add(this.pic_Unit_PrereqDistrict);
            this.groupBox5.Controls.Add(this.pic_Unit_PrereqPopulation);
            this.groupBox5.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox5.Location = new System.Drawing.Point(642, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 178);
            this.groupBox5.TabIndex = 118;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prereqs:";
            // 
            // cbx_Unit_PrereqDistrict
            // 
            this.cbx_Unit_PrereqDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_PrereqDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_PrereqDistrict.DropDownWidth = 267;
            this.cbx_Unit_PrereqDistrict.Location = new System.Drawing.Point(44, 103);
            this.cbx_Unit_PrereqDistrict.Name = "cbx_Unit_PrereqDistrict";
            this.cbx_Unit_PrereqDistrict.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_PrereqDistrict.Sorted = true;
            this.cbx_Unit_PrereqDistrict.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PrereqDistrict.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PrereqDistrict.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_PrereqDistrict.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_PrereqDistrict.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_PrereqDistrict.TabIndex = 106;
            this.cbx_Unit_PrereqDistrict.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_PrereqCivic
            // 
            this.cbx_Unit_PrereqCivic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_PrereqCivic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_PrereqCivic.DropDownWidth = 267;
            this.cbx_Unit_PrereqCivic.Location = new System.Drawing.Point(44, 68);
            this.cbx_Unit_PrereqCivic.Name = "cbx_Unit_PrereqCivic";
            this.cbx_Unit_PrereqCivic.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_PrereqCivic.Sorted = true;
            this.cbx_Unit_PrereqCivic.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PrereqCivic.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PrereqCivic.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_PrereqCivic.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_PrereqCivic.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_PrereqCivic.TabIndex = 105;
            this.cbx_Unit_PrereqCivic.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_PrereqTech
            // 
            this.cbx_Unit_PrereqTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_PrereqTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_PrereqTech.DropDownWidth = 267;
            this.cbx_Unit_PrereqTech.Location = new System.Drawing.Point(44, 31);
            this.cbx_Unit_PrereqTech.Name = "cbx_Unit_PrereqTech";
            this.cbx_Unit_PrereqTech.Size = new System.Drawing.Size(323, 23);
            this.cbx_Unit_PrereqTech.Sorted = true;
            this.cbx_Unit_PrereqTech.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PrereqTech.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PrereqTech.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_PrereqTech.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_PrereqTech.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_PrereqTech.TabIndex = 58;
            this.cbx_Unit_PrereqTech.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_PrereqTech
            // 
            this.pic_Unit_PrereqTech.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PrereqTech.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PrereqTech.Image")));
            this.pic_Unit_PrereqTech.Location = new System.Drawing.Point(6, 30);
            this.pic_Unit_PrereqTech.Name = "pic_Unit_PrereqTech";
            this.pic_Unit_PrereqTech.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PrereqTech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PrereqTech.TabIndex = 101;
            this.pic_Unit_PrereqTech.TabStop = false;
            // 
            // tbx_Unit_PrereqPopulation
            // 
            this.tbx_Unit_PrereqPopulation.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_PrereqPopulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_PrereqPopulation.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_PrereqPopulation.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_PrereqPopulation.Location = new System.Drawing.Point(43, 139);
            this.tbx_Unit_PrereqPopulation.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Unit_PrereqPopulation.Name = "tbx_Unit_PrereqPopulation";
            this.tbx_Unit_PrereqPopulation.Size = new System.Drawing.Size(325, 23);
            this.tbx_Unit_PrereqPopulation.TabIndex = 99;
            this.tbx_Unit_PrereqPopulation.WordWrap = false;
            // 
            // pic_Unit_PrereqCivic
            // 
            this.pic_Unit_PrereqCivic.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PrereqCivic.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PrereqCivic.Image")));
            this.pic_Unit_PrereqCivic.Location = new System.Drawing.Point(6, 68);
            this.pic_Unit_PrereqCivic.Name = "pic_Unit_PrereqCivic";
            this.pic_Unit_PrereqCivic.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PrereqCivic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PrereqCivic.TabIndex = 102;
            this.pic_Unit_PrereqCivic.TabStop = false;
            // 
            // pic_Unit_PrereqDistrict
            // 
            this.pic_Unit_PrereqDistrict.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PrereqDistrict.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PrereqDistrict.Image")));
            this.pic_Unit_PrereqDistrict.Location = new System.Drawing.Point(6, 103);
            this.pic_Unit_PrereqDistrict.Name = "pic_Unit_PrereqDistrict";
            this.pic_Unit_PrereqDistrict.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PrereqDistrict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PrereqDistrict.TabIndex = 103;
            this.pic_Unit_PrereqDistrict.TabStop = false;
            // 
            // pic_Unit_PrereqPopulation
            // 
            this.pic_Unit_PrereqPopulation.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PrereqPopulation.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PrereqPopulation.Image")));
            this.pic_Unit_PrereqPopulation.Location = new System.Drawing.Point(6, 141);
            this.pic_Unit_PrereqPopulation.Name = "pic_Unit_PrereqPopulation";
            this.pic_Unit_PrereqPopulation.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PrereqPopulation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PrereqPopulation.TabIndex = 104;
            this.pic_Unit_PrereqPopulation.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pic_Unit_CostProgressionModel);
            this.groupBox4.Controls.Add(this.cbx_Unit_PurchaseYield);
            this.groupBox4.Controls.Add(this.tbx_Unit_CostProgressionParam1);
            this.groupBox4.Controls.Add(this.tbx_Unit_CostProgressionModel);
            this.groupBox4.Controls.Add(this.cbx_Unit_StrategicResource);
            this.groupBox4.Controls.Add(this.pic_Unit_PurchaseYield);
            this.groupBox4.Controls.Add(this.pic_Unit_StrategicResource);
            this.groupBox4.Controls.Add(this.tbx_Unit_XP2_ResourceCost);
            this.groupBox4.Controls.Add(this.pic_Unit_Cost);
            this.groupBox4.Controls.Add(this.tbx_Unit_Cost);
            this.groupBox4.Controls.Add(this.tbx_Unit_PopulationCost);
            this.groupBox4.Controls.Add(this.chbx_Unit_MustPurchase);
            this.groupBox4.Controls.Add(this.pic_Unit_PopulationCost);
            this.groupBox4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox4.Location = new System.Drawing.Point(642, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 154);
            this.groupBox4.TabIndex = 117;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cost:";
            // 
            // pic_Unit_CostProgressionModel
            // 
            this.pic_Unit_CostProgressionModel.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_CostProgressionModel.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_CostProgressionModel.Image")));
            this.pic_Unit_CostProgressionModel.Location = new System.Drawing.Point(6, 89);
            this.pic_Unit_CostProgressionModel.Name = "pic_Unit_CostProgressionModel";
            this.pic_Unit_CostProgressionModel.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_CostProgressionModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_CostProgressionModel.TabIndex = 152;
            this.pic_Unit_CostProgressionModel.TabStop = false;
            // 
            // cbx_Unit_PurchaseYield
            // 
            this.cbx_Unit_PurchaseYield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_PurchaseYield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_PurchaseYield.DropDownWidth = 267;
            this.cbx_Unit_PurchaseYield.Location = new System.Drawing.Point(43, 60);
            this.cbx_Unit_PurchaseYield.Name = "cbx_Unit_PurchaseYield";
            this.cbx_Unit_PurchaseYield.Size = new System.Drawing.Size(282, 23);
            this.cbx_Unit_PurchaseYield.Sorted = true;
            this.cbx_Unit_PurchaseYield.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PurchaseYield.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PurchaseYield.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_PurchaseYield.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_PurchaseYield.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_PurchaseYield.TabIndex = 146;
            this.cbx_Unit_PurchaseYield.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // tbx_Unit_CostProgressionParam1
            // 
            this.tbx_Unit_CostProgressionParam1.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_CostProgressionParam1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_CostProgressionParam1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_CostProgressionParam1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_CostProgressionParam1.Location = new System.Drawing.Point(325, 94);
            this.tbx_Unit_CostProgressionParam1.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_CostProgressionParam1.Name = "tbx_Unit_CostProgressionParam1";
            this.tbx_Unit_CostProgressionParam1.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_CostProgressionParam1.TabIndex = 146;
            this.tbx_Unit_CostProgressionParam1.WordWrap = false;
            // 
            // tbx_Unit_CostProgressionModel
            // 
            this.tbx_Unit_CostProgressionModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbx_Unit_CostProgressionModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbx_Unit_CostProgressionModel.DropDownWidth = 267;
            this.tbx_Unit_CostProgressionModel.Location = new System.Drawing.Point(43, 93);
            this.tbx_Unit_CostProgressionModel.Name = "tbx_Unit_CostProgressionModel";
            this.tbx_Unit_CostProgressionModel.Size = new System.Drawing.Size(282, 23);
            this.tbx_Unit_CostProgressionModel.Sorted = true;
            this.tbx_Unit_CostProgressionModel.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_CostProgressionModel.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_CostProgressionModel.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbx_Unit_CostProgressionModel.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Unit_CostProgressionModel.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_CostProgressionModel.TabIndex = 107;
            this.tbx_Unit_CostProgressionModel.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_StrategicResource
            // 
            this.cbx_Unit_StrategicResource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_StrategicResource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_StrategicResource.DropDownWidth = 267;
            this.cbx_Unit_StrategicResource.Location = new System.Drawing.Point(43, 126);
            this.cbx_Unit_StrategicResource.Name = "cbx_Unit_StrategicResource";
            this.cbx_Unit_StrategicResource.Size = new System.Drawing.Size(282, 23);
            this.cbx_Unit_StrategicResource.Sorted = true;
            this.cbx_Unit_StrategicResource.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_StrategicResource.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_StrategicResource.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_StrategicResource.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_StrategicResource.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_StrategicResource.TabIndex = 145;
            this.cbx_Unit_StrategicResource.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_PurchaseYield
            // 
            this.pic_Unit_PurchaseYield.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PurchaseYield.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PurchaseYield.Image")));
            this.pic_Unit_PurchaseYield.Location = new System.Drawing.Point(6, 57);
            this.pic_Unit_PurchaseYield.Name = "pic_Unit_PurchaseYield";
            this.pic_Unit_PurchaseYield.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PurchaseYield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PurchaseYield.TabIndex = 138;
            this.pic_Unit_PurchaseYield.TabStop = false;
            // 
            // pic_Unit_StrategicResource
            // 
            this.pic_Unit_StrategicResource.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_StrategicResource.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_StrategicResource.Image")));
            this.pic_Unit_StrategicResource.Location = new System.Drawing.Point(7, 121);
            this.pic_Unit_StrategicResource.Name = "pic_Unit_StrategicResource";
            this.pic_Unit_StrategicResource.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_StrategicResource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_StrategicResource.TabIndex = 135;
            this.pic_Unit_StrategicResource.TabStop = false;
            // 
            // tbx_Unit_XP2_ResourceCost
            // 
            this.tbx_Unit_XP2_ResourceCost.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_XP2_ResourceCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_XP2_ResourceCost.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_XP2_ResourceCost.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_XP2_ResourceCost.Location = new System.Drawing.Point(327, 128);
            this.tbx_Unit_XP2_ResourceCost.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_XP2_ResourceCost.Name = "tbx_Unit_XP2_ResourceCost";
            this.tbx_Unit_XP2_ResourceCost.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_XP2_ResourceCost.TabIndex = 133;
            this.tbx_Unit_XP2_ResourceCost.WordWrap = false;
            // 
            // pic_Unit_Cost
            // 
            this.pic_Unit_Cost.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Cost.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Cost.Image")));
            this.pic_Unit_Cost.Location = new System.Drawing.Point(6, 23);
            this.pic_Unit_Cost.Name = "pic_Unit_Cost";
            this.pic_Unit_Cost.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_Cost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_Cost.TabIndex = 65;
            this.pic_Unit_Cost.TabStop = false;
            // 
            // tbx_Unit_Cost
            // 
            this.tbx_Unit_Cost.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_Cost.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_Cost.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_Cost.Location = new System.Drawing.Point(43, 26);
            this.tbx_Unit_Cost.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_Cost.Name = "tbx_Unit_Cost";
            this.tbx_Unit_Cost.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_Cost.TabIndex = 64;
            this.tbx_Unit_Cost.WordWrap = false;
            // 
            // tbx_Unit_PopulationCost
            // 
            this.tbx_Unit_PopulationCost.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_PopulationCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_PopulationCost.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_PopulationCost.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_PopulationCost.Location = new System.Drawing.Point(165, 26);
            this.tbx_Unit_PopulationCost.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_PopulationCost.Name = "tbx_Unit_PopulationCost";
            this.tbx_Unit_PopulationCost.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_PopulationCost.TabIndex = 66;
            this.tbx_Unit_PopulationCost.WordWrap = false;
            // 
            // chbx_Unit_MustPurchase
            // 
            this.chbx_Unit_MustPurchase.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_MustPurchase.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_MustPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_MustPurchase.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_MustPurchase.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_MustPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_MustPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_MustPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_MustPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_MustPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_MustPurchase.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_MustPurchase.Image")));
            this.chbx_Unit_MustPurchase.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_MustPurchase.Location = new System.Drawing.Point(259, 26);
            this.chbx_Unit_MustPurchase.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_MustPurchase.Name = "chbx_Unit_MustPurchase";
            this.chbx_Unit_MustPurchase.Size = new System.Drawing.Size(126, 27);
            this.chbx_Unit_MustPurchase.TabIndex = 82;
            this.chbx_Unit_MustPurchase.Text = "MustPurchase";
            this.chbx_Unit_MustPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_MustPurchase.UseVisualStyleBackColor = true;
            this.chbx_Unit_MustPurchase.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // pic_Unit_PopulationCost
            // 
            this.pic_Unit_PopulationCost.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PopulationCost.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PopulationCost.Image")));
            this.pic_Unit_PopulationCost.Location = new System.Drawing.Point(128, 23);
            this.pic_Unit_PopulationCost.Name = "pic_Unit_PopulationCost";
            this.pic_Unit_PopulationCost.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PopulationCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PopulationCost.TabIndex = 100;
            this.pic_Unit_PopulationCost.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbx_Unit_PromotionClass);
            this.groupBox3.Controls.Add(this.pic_Unit_InitialLevel);
            this.groupBox3.Controls.Add(this.pictureBox29);
            this.groupBox3.Controls.Add(this.tbx_Unit_Flavor);
            this.groupBox3.Controls.Add(this.cbx_Unit_FormationClass);
            this.groupBox3.Controls.Add(this.pic_Unit_AirSlots);
            this.groupBox3.Controls.Add(this.pic_Unit_FormationClass);
            this.groupBox3.Controls.Add(this.tbx_Unit_InitialLevel);
            this.groupBox3.Controls.Add(this.cbx_Unit_Domain);
            this.groupBox3.Controls.Add(this.pic_Unit_Domain);
            this.groupBox3.Controls.Add(this.chbx_Unit_CanCapture);
            this.groupBox3.Controls.Add(this.pic_Unit_PromotionClass);
            this.groupBox3.Controls.Add(this.chbx_Unit_CanRetreatWhenCaptured);
            this.groupBox3.Controls.Add(this.chbx_Unit_XP2_CanEarnExperience);
            this.groupBox3.Controls.Add(this.chbx_Unit_XP2_CanFormMilitaryFormation);
            this.groupBox3.Controls.Add(this.tbx_Unit_AirSlots);
            this.groupBox3.Controls.Add(this.chbx_Unit_CanTargetAir);
            this.groupBox3.Controls.Add(this.chbx_Unit_ZoneOfControl);
            this.groupBox3.Controls.Add(this.chbx_Unit_CanTrain);
            this.groupBox3.Controls.Add(this.chbx_Unit_CanEarnExperience);
            this.groupBox3.Controls.Add(this.chbx_Unit_WMDCapable);
            this.groupBox3.Controls.Add(this.chbx_Unit_UseMaxMeleeTrainedStrength);
            this.groupBox3.Controls.Add(this.pic_Unit_Combat);
            this.groupBox3.Controls.Add(this.tbx_Unit_Combat);
            this.groupBox3.Controls.Add(this.tbx_Unit_RangedCombat);
            this.groupBox3.Controls.Add(this.pic_Unit_RangedCombat);
            this.groupBox3.Controls.Add(this.tbx_Unit_BaseMoves);
            this.groupBox3.Controls.Add(this.pic_Unit_BaseMoves);
            this.groupBox3.Controls.Add(this.tbx_Unit_Range);
            this.groupBox3.Controls.Add(this.pic_Unit_Range);
            this.groupBox3.Controls.Add(this.tbx_Unit_BaseSightRange);
            this.groupBox3.Controls.Add(this.pic_Unit_BaseSightRange);
            this.groupBox3.Controls.Add(this.tbx_Unit_Bombard);
            this.groupBox3.Controls.Add(this.pic_Unit_Bombard);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 289);
            this.groupBox3.TabIndex = 117;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Combat:";
            // 
            // cbx_Unit_PromotionClass
            // 
            this.cbx_Unit_PromotionClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_PromotionClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_PromotionClass.DropDownWidth = 267;
            this.cbx_Unit_PromotionClass.Location = new System.Drawing.Point(314, 251);
            this.cbx_Unit_PromotionClass.Name = "cbx_Unit_PromotionClass";
            this.cbx_Unit_PromotionClass.Size = new System.Drawing.Size(313, 23);
            this.cbx_Unit_PromotionClass.Sorted = true;
            this.cbx_Unit_PromotionClass.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PromotionClass.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_PromotionClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_PromotionClass.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_PromotionClass.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_PromotionClass.TabIndex = 146;
            this.cbx_Unit_PromotionClass.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_InitialLevel
            // 
            this.pic_Unit_InitialLevel.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_InitialLevel.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_InitialLevel.Image")));
            this.pic_Unit_InitialLevel.Location = new System.Drawing.Point(277, 96);
            this.pic_Unit_InitialLevel.Name = "pic_Unit_InitialLevel";
            this.pic_Unit_InitialLevel.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_InitialLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_InitialLevel.TabIndex = 150;
            this.pic_Unit_InitialLevel.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(377, 131);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(32, 32);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox29.TabIndex = 151;
            this.pictureBox29.TabStop = false;
            // 
            // tbx_Unit_Flavor
            // 
            this.tbx_Unit_Flavor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbx_Unit_Flavor.DropDownWidth = 267;
            this.tbx_Unit_Flavor.Location = new System.Drawing.Point(413, 135);
            this.tbx_Unit_Flavor.Name = "tbx_Unit_Flavor";
            this.tbx_Unit_Flavor.Size = new System.Drawing.Size(190, 23);
            this.tbx_Unit_Flavor.Sorted = true;
            this.tbx_Unit_Flavor.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Flavor.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Flavor.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbx_Unit_Flavor.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tbx_Unit_Flavor.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_Flavor.TabIndex = 148;
            this.tbx_Unit_Flavor.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // cbx_Unit_FormationClass
            // 
            this.cbx_Unit_FormationClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_FormationClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_FormationClass.DropDownWidth = 267;
            this.cbx_Unit_FormationClass.Location = new System.Drawing.Point(315, 219);
            this.cbx_Unit_FormationClass.Name = "cbx_Unit_FormationClass";
            this.cbx_Unit_FormationClass.Size = new System.Drawing.Size(312, 23);
            this.cbx_Unit_FormationClass.Sorted = true;
            this.cbx_Unit_FormationClass.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_FormationClass.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_FormationClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_FormationClass.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_FormationClass.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_FormationClass.TabIndex = 145;
            this.cbx_Unit_FormationClass.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_AirSlots
            // 
            this.pic_Unit_AirSlots.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_AirSlots.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_AirSlots.Image")));
            this.pic_Unit_AirSlots.Location = new System.Drawing.Point(277, 131);
            this.pic_Unit_AirSlots.Name = "pic_Unit_AirSlots";
            this.pic_Unit_AirSlots.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_AirSlots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_AirSlots.TabIndex = 144;
            this.pic_Unit_AirSlots.TabStop = false;
            // 
            // pic_Unit_FormationClass
            // 
            this.pic_Unit_FormationClass.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_FormationClass.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_FormationClass.Image")));
            this.pic_Unit_FormationClass.Location = new System.Drawing.Point(277, 216);
            this.pic_Unit_FormationClass.Name = "pic_Unit_FormationClass";
            this.pic_Unit_FormationClass.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_FormationClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_FormationClass.TabIndex = 144;
            this.pic_Unit_FormationClass.TabStop = false;
            // 
            // tbx_Unit_InitialLevel
            // 
            this.tbx_Unit_InitialLevel.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_InitialLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_InitialLevel.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_InitialLevel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_InitialLevel.Location = new System.Drawing.Point(312, 98);
            this.tbx_Unit_InitialLevel.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_InitialLevel.Name = "tbx_Unit_InitialLevel";
            this.tbx_Unit_InitialLevel.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_InitialLevel.TabIndex = 115;
            this.tbx_Unit_InitialLevel.WordWrap = false;
            // 
            // cbx_Unit_Domain
            // 
            this.cbx_Unit_Domain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Unit_Domain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Unit_Domain.DropDownWidth = 267;
            this.cbx_Unit_Domain.Location = new System.Drawing.Point(314, 190);
            this.cbx_Unit_Domain.Name = "cbx_Unit_Domain";
            this.cbx_Unit_Domain.Size = new System.Drawing.Size(313, 23);
            this.cbx_Unit_Domain.Sorted = true;
            this.cbx_Unit_Domain.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_Domain.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.WindowText;
            this.cbx_Unit_Domain.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_Unit_Domain.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.cbx_Unit_Domain.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_Unit_Domain.TabIndex = 108;
            this.cbx_Unit_Domain.Enter += new System.EventHandler(this.AllKryptonComboBoxes_Enter);
            // 
            // pic_Unit_Domain
            // 
            this.pic_Unit_Domain.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Domain.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Domain.Image")));
            this.pic_Unit_Domain.Location = new System.Drawing.Point(277, 185);
            this.pic_Unit_Domain.Name = "pic_Unit_Domain";
            this.pic_Unit_Domain.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_Domain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_Domain.TabIndex = 143;
            this.pic_Unit_Domain.TabStop = false;
            // 
            // chbx_Unit_CanCapture
            // 
            this.chbx_Unit_CanCapture.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_CanCapture.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanCapture.Checked = true;
            this.chbx_Unit_CanCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_Unit_CanCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_CanCapture.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_CanCapture.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_CanCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_CanCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_CanCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_CanCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_CanCapture.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_CanCapture.Image")));
            this.chbx_Unit_CanCapture.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_CanCapture.Location = new System.Drawing.Point(7, 47);
            this.chbx_Unit_CanCapture.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_CanCapture.Name = "chbx_Unit_CanCapture";
            this.chbx_Unit_CanCapture.Size = new System.Drawing.Size(116, 27);
            this.chbx_Unit_CanCapture.TabIndex = 79;
            this.chbx_Unit_CanCapture.Text = "CanCapture";
            this.chbx_Unit_CanCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_CanCapture.UseVisualStyleBackColor = true;
            this.chbx_Unit_CanCapture.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // pic_Unit_PromotionClass
            // 
            this.pic_Unit_PromotionClass.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_PromotionClass.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_PromotionClass.Image")));
            this.pic_Unit_PromotionClass.Location = new System.Drawing.Point(277, 250);
            this.pic_Unit_PromotionClass.Name = "pic_Unit_PromotionClass";
            this.pic_Unit_PromotionClass.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_PromotionClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_PromotionClass.TabIndex = 115;
            this.pic_Unit_PromotionClass.TabStop = false;
            // 
            // chbx_Unit_CanRetreatWhenCaptured
            // 
            this.chbx_Unit_CanRetreatWhenCaptured.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_CanRetreatWhenCaptured.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanRetreatWhenCaptured.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_CanRetreatWhenCaptured.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_CanRetreatWhenCaptured.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanRetreatWhenCaptured.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_CanRetreatWhenCaptured.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_CanRetreatWhenCaptured.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_CanRetreatWhenCaptured.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_CanRetreatWhenCaptured.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_CanRetreatWhenCaptured.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_CanRetreatWhenCaptured.Image")));
            this.chbx_Unit_CanRetreatWhenCaptured.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_CanRetreatWhenCaptured.Location = new System.Drawing.Point(7, 235);
            this.chbx_Unit_CanRetreatWhenCaptured.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_CanRetreatWhenCaptured.Name = "chbx_Unit_CanRetreatWhenCaptured";
            this.chbx_Unit_CanRetreatWhenCaptured.Size = new System.Drawing.Size(226, 27);
            this.chbx_Unit_CanRetreatWhenCaptured.TabIndex = 80;
            this.chbx_Unit_CanRetreatWhenCaptured.Text = "CanRetreatWhenCaptured";
            this.chbx_Unit_CanRetreatWhenCaptured.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_CanRetreatWhenCaptured.UseVisualStyleBackColor = true;
            this.chbx_Unit_CanRetreatWhenCaptured.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_XP2_CanEarnExperience
            // 
            this.chbx_Unit_XP2_CanEarnExperience.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_XP2_CanEarnExperience.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanEarnExperience.Checked = true;
            this.chbx_Unit_XP2_CanEarnExperience.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_Unit_XP2_CanEarnExperience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_XP2_CanEarnExperience.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_XP2_CanEarnExperience.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanEarnExperience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_XP2_CanEarnExperience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_XP2_CanEarnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_XP2_CanEarnExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_XP2_CanEarnExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_XP2_CanEarnExperience.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_XP2_CanEarnExperience.Image")));
            this.chbx_Unit_XP2_CanEarnExperience.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_XP2_CanEarnExperience.Location = new System.Drawing.Point(7, 182);
            this.chbx_Unit_XP2_CanEarnExperience.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_XP2_CanEarnExperience.Name = "chbx_Unit_XP2_CanEarnExperience";
            this.chbx_Unit_XP2_CanEarnExperience.Size = new System.Drawing.Size(159, 27);
            this.chbx_Unit_XP2_CanEarnExperience.TabIndex = 120;
            this.chbx_Unit_XP2_CanEarnExperience.Text = "CanEarnExperience";
            this.chbx_Unit_XP2_CanEarnExperience.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_XP2_CanEarnExperience.UseVisualStyleBackColor = true;
            this.chbx_Unit_XP2_CanEarnExperience.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_XP2_CanFormMilitaryFormation
            // 
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Checked = true;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_XP2_CanFormMilitaryFormation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_XP2_CanFormMilitaryFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_XP2_CanFormMilitaryFormation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_XP2_CanFormMilitaryFormation.Image")));
            this.chbx_Unit_XP2_CanFormMilitaryFormation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Location = new System.Drawing.Point(7, 209);
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Name = "chbx_Unit_XP2_CanFormMilitaryFormation";
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Size = new System.Drawing.Size(226, 27);
            this.chbx_Unit_XP2_CanFormMilitaryFormation.TabIndex = 136;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.Text = "CanFormMilitaryFormation";
            this.chbx_Unit_XP2_CanFormMilitaryFormation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.UseVisualStyleBackColor = true;
            this.chbx_Unit_XP2_CanFormMilitaryFormation.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Unit_AirSlots
            // 
            this.tbx_Unit_AirSlots.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_AirSlots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_AirSlots.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_AirSlots.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_AirSlots.Location = new System.Drawing.Point(312, 136);
            this.tbx_Unit_AirSlots.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_AirSlots.Name = "tbx_Unit_AirSlots";
            this.tbx_Unit_AirSlots.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_AirSlots.TabIndex = 122;
            this.tbx_Unit_AirSlots.WordWrap = false;
            // 
            // chbx_Unit_CanTargetAir
            // 
            this.chbx_Unit_CanTargetAir.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_CanTargetAir.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanTargetAir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_CanTargetAir.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_CanTargetAir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanTargetAir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_CanTargetAir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_CanTargetAir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_CanTargetAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_CanTargetAir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_CanTargetAir.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_CanTargetAir.Image")));
            this.chbx_Unit_CanTargetAir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_CanTargetAir.Location = new System.Drawing.Point(7, 74);
            this.chbx_Unit_CanTargetAir.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_CanTargetAir.Name = "chbx_Unit_CanTargetAir";
            this.chbx_Unit_CanTargetAir.Size = new System.Drawing.Size(122, 27);
            this.chbx_Unit_CanTargetAir.TabIndex = 84;
            this.chbx_Unit_CanTargetAir.Text = "CanTargetAir";
            this.chbx_Unit_CanTargetAir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_CanTargetAir.UseVisualStyleBackColor = true;
            this.chbx_Unit_CanTargetAir.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_ZoneOfControl
            // 
            this.chbx_Unit_ZoneOfControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_ZoneOfControl.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_ZoneOfControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_ZoneOfControl.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_ZoneOfControl.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_ZoneOfControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_ZoneOfControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_ZoneOfControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_ZoneOfControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_ZoneOfControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_ZoneOfControl.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_ZoneOfControl.Image")));
            this.chbx_Unit_ZoneOfControl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_ZoneOfControl.Location = new System.Drawing.Point(7, 101);
            this.chbx_Unit_ZoneOfControl.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_ZoneOfControl.Name = "chbx_Unit_ZoneOfControl";
            this.chbx_Unit_ZoneOfControl.Size = new System.Drawing.Size(135, 27);
            this.chbx_Unit_ZoneOfControl.TabIndex = 85;
            this.chbx_Unit_ZoneOfControl.Text = "ZoneOfControl";
            this.chbx_Unit_ZoneOfControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_ZoneOfControl.UseVisualStyleBackColor = true;
            this.chbx_Unit_ZoneOfControl.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_CanTrain
            // 
            this.chbx_Unit_CanTrain.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_CanTrain.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanTrain.Checked = true;
            this.chbx_Unit_CanTrain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_Unit_CanTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_CanTrain.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_CanTrain.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanTrain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_CanTrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_CanTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_CanTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_CanTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_CanTrain.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_CanTrain.Image")));
            this.chbx_Unit_CanTrain.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_CanTrain.Location = new System.Drawing.Point(7, 20);
            this.chbx_Unit_CanTrain.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_CanTrain.Name = "chbx_Unit_CanTrain";
            this.chbx_Unit_CanTrain.Size = new System.Drawing.Size(116, 27);
            this.chbx_Unit_CanTrain.TabIndex = 87;
            this.chbx_Unit_CanTrain.Text = "CanTrain";
            this.chbx_Unit_CanTrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_CanTrain.UseVisualStyleBackColor = true;
            this.chbx_Unit_CanTrain.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_CanEarnExperience
            // 
            this.chbx_Unit_CanEarnExperience.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_CanEarnExperience.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanEarnExperience.Checked = true;
            this.chbx_Unit_CanEarnExperience.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_Unit_CanEarnExperience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_CanEarnExperience.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_CanEarnExperience.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_CanEarnExperience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_CanEarnExperience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_CanEarnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_CanEarnExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_CanEarnExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_CanEarnExperience.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_CanEarnExperience.Image")));
            this.chbx_Unit_CanEarnExperience.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_CanEarnExperience.Location = new System.Drawing.Point(7, 155);
            this.chbx_Unit_CanEarnExperience.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_CanEarnExperience.Name = "chbx_Unit_CanEarnExperience";
            this.chbx_Unit_CanEarnExperience.Size = new System.Drawing.Size(159, 27);
            this.chbx_Unit_CanEarnExperience.TabIndex = 88;
            this.chbx_Unit_CanEarnExperience.Text = "CanEarnExperience";
            this.chbx_Unit_CanEarnExperience.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_CanEarnExperience.UseVisualStyleBackColor = true;
            this.chbx_Unit_CanEarnExperience.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_WMDCapable
            // 
            this.chbx_Unit_WMDCapable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_WMDCapable.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_WMDCapable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_WMDCapable.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_WMDCapable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_WMDCapable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_WMDCapable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_WMDCapable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_WMDCapable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_WMDCapable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_WMDCapable.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_WMDCapable.Image")));
            this.chbx_Unit_WMDCapable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_WMDCapable.Location = new System.Drawing.Point(7, 128);
            this.chbx_Unit_WMDCapable.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_WMDCapable.Name = "chbx_Unit_WMDCapable";
            this.chbx_Unit_WMDCapable.Size = new System.Drawing.Size(122, 27);
            this.chbx_Unit_WMDCapable.TabIndex = 89;
            this.chbx_Unit_WMDCapable.Text = "WMDCapable";
            this.chbx_Unit_WMDCapable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_WMDCapable.UseVisualStyleBackColor = true;
            this.chbx_Unit_WMDCapable.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_UseMaxMeleeTrainedStrength
            // 
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_UseMaxMeleeTrainedStrength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_UseMaxMeleeTrainedStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_UseMaxMeleeTrainedStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_UseMaxMeleeTrainedStrength.Image")));
            this.chbx_Unit_UseMaxMeleeTrainedStrength.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Location = new System.Drawing.Point(7, 259);
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Name = "chbx_Unit_UseMaxMeleeTrainedStrength";
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Size = new System.Drawing.Size(226, 27);
            this.chbx_Unit_UseMaxMeleeTrainedStrength.TabIndex = 95;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.Text = "UseMaxMeleeTrainedStrength";
            this.chbx_Unit_UseMaxMeleeTrainedStrength.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.UseVisualStyleBackColor = true;
            this.chbx_Unit_UseMaxMeleeTrainedStrength.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // pic_Unit_Combat
            // 
            this.pic_Unit_Combat.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Combat.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Combat.Image")));
            this.pic_Unit_Combat.Location = new System.Drawing.Point(277, 24);
            this.pic_Unit_Combat.Name = "pic_Unit_Combat";
            this.pic_Unit_Combat.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_Combat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_Combat.TabIndex = 54;
            this.pic_Unit_Combat.TabStop = false;
            // 
            // tbx_Unit_Combat
            // 
            this.tbx_Unit_Combat.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Combat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_Combat.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_Combat.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_Combat.Location = new System.Drawing.Point(312, 26);
            this.tbx_Unit_Combat.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_Combat.Name = "tbx_Unit_Combat";
            this.tbx_Unit_Combat.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_Combat.TabIndex = 16;
            this.tbx_Unit_Combat.WordWrap = false;
            // 
            // tbx_Unit_RangedCombat
            // 
            this.tbx_Unit_RangedCombat.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_RangedCombat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_RangedCombat.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_RangedCombat.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_RangedCombat.Location = new System.Drawing.Point(412, 26);
            this.tbx_Unit_RangedCombat.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_RangedCombat.Name = "tbx_Unit_RangedCombat";
            this.tbx_Unit_RangedCombat.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_RangedCombat.TabIndex = 17;
            this.tbx_Unit_RangedCombat.WordWrap = false;
            // 
            // pic_Unit_RangedCombat
            // 
            this.pic_Unit_RangedCombat.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_RangedCombat.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_RangedCombat.Image")));
            this.pic_Unit_RangedCombat.Location = new System.Drawing.Point(377, 24);
            this.pic_Unit_RangedCombat.Name = "pic_Unit_RangedCombat";
            this.pic_Unit_RangedCombat.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_RangedCombat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_RangedCombat.TabIndex = 55;
            this.pic_Unit_RangedCombat.TabStop = false;
            // 
            // tbx_Unit_BaseMoves
            // 
            this.tbx_Unit_BaseMoves.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_BaseMoves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_BaseMoves.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_BaseMoves.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_BaseMoves.Location = new System.Drawing.Point(312, 60);
            this.tbx_Unit_BaseMoves.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_BaseMoves.Name = "tbx_Unit_BaseMoves";
            this.tbx_Unit_BaseMoves.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_BaseMoves.TabIndex = 56;
            this.tbx_Unit_BaseMoves.WordWrap = false;
            // 
            // pic_Unit_BaseMoves
            // 
            this.pic_Unit_BaseMoves.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_BaseMoves.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_BaseMoves.Image")));
            this.pic_Unit_BaseMoves.Location = new System.Drawing.Point(277, 58);
            this.pic_Unit_BaseMoves.Name = "pic_Unit_BaseMoves";
            this.pic_Unit_BaseMoves.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_BaseMoves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_BaseMoves.TabIndex = 57;
            this.pic_Unit_BaseMoves.TabStop = false;
            // 
            // tbx_Unit_Range
            // 
            this.tbx_Unit_Range.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Range.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_Range.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_Range.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_Range.Location = new System.Drawing.Point(512, 57);
            this.tbx_Unit_Range.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_Range.Name = "tbx_Unit_Range";
            this.tbx_Unit_Range.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_Range.TabIndex = 58;
            this.tbx_Unit_Range.WordWrap = false;
            // 
            // pic_Unit_Range
            // 
            this.pic_Unit_Range.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Range.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Range.Image")));
            this.pic_Unit_Range.Location = new System.Drawing.Point(477, 55);
            this.pic_Unit_Range.Name = "pic_Unit_Range";
            this.pic_Unit_Range.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_Range.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_Range.TabIndex = 59;
            this.pic_Unit_Range.TabStop = false;
            // 
            // tbx_Unit_BaseSightRange
            // 
            this.tbx_Unit_BaseSightRange.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_BaseSightRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_BaseSightRange.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_BaseSightRange.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_BaseSightRange.Location = new System.Drawing.Point(412, 60);
            this.tbx_Unit_BaseSightRange.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_BaseSightRange.Name = "tbx_Unit_BaseSightRange";
            this.tbx_Unit_BaseSightRange.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_BaseSightRange.TabIndex = 60;
            this.tbx_Unit_BaseSightRange.WordWrap = false;
            // 
            // pic_Unit_BaseSightRange
            // 
            this.pic_Unit_BaseSightRange.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_BaseSightRange.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_BaseSightRange.Image")));
            this.pic_Unit_BaseSightRange.Location = new System.Drawing.Point(377, 58);
            this.pic_Unit_BaseSightRange.Name = "pic_Unit_BaseSightRange";
            this.pic_Unit_BaseSightRange.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_BaseSightRange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_BaseSightRange.TabIndex = 61;
            this.pic_Unit_BaseSightRange.TabStop = false;
            // 
            // tbx_Unit_Bombard
            // 
            this.tbx_Unit_Bombard.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_Bombard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_Bombard.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Unit_Bombard.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_Bombard.Location = new System.Drawing.Point(512, 25);
            this.tbx_Unit_Bombard.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_Bombard.Name = "tbx_Unit_Bombard";
            this.tbx_Unit_Bombard.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_Bombard.TabIndex = 62;
            this.tbx_Unit_Bombard.WordWrap = false;
            // 
            // pic_Unit_Bombard
            // 
            this.pic_Unit_Bombard.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Bombard.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Bombard.Image")));
            this.pic_Unit_Bombard.Location = new System.Drawing.Point(477, 23);
            this.pic_Unit_Bombard.Name = "pic_Unit_Bombard";
            this.pic_Unit_Bombard.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_Bombard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_Bombard.TabIndex = 63;
            this.pic_Unit_Bombard.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pic_Unit_ReligiousStrength);
            this.groupBox2.Controls.Add(this.tbx_Unit_ReligiousStrength);
            this.groupBox2.Controls.Add(this.chbx_Unit_FoundReligion);
            this.groupBox2.Controls.Add(this.chbx_Unit_EvangelizeBelief);
            this.groupBox2.Controls.Add(this.tbx_Unit_ReligionEvictPercent);
            this.groupBox2.Controls.Add(this.chbx_Unit_LaunchInquisition);
            this.groupBox2.Controls.Add(this.chbx_Unit_RequiresInquisition);
            this.groupBox2.Controls.Add(this.tbx_Unit_SpreadCharges);
            this.groupBox2.Controls.Add(this.chbx_Unit_TrackReligion);
            this.groupBox2.Controls.Add(this.chbx_Unit_EnabledByReligion);
            this.groupBox2.Controls.Add(this.tbx_Unit_ReligiousHealCharges);
            this.groupBox2.Controls.Add(this.pic_Unit_SpreadCharges);
            this.groupBox2.Controls.Add(this.pic_Unit_ReligionEvictPercent);
            this.groupBox2.Controls.Add(this.pic_Unit_ReligiousHealCharges);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox2.Location = new System.Drawing.Point(2, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 195);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Religion:";
            // 
            // pic_Unit_ReligiousStrength
            // 
            this.pic_Unit_ReligiousStrength.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_ReligiousStrength.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_ReligiousStrength.Image")));
            this.pic_Unit_ReligiousStrength.Location = new System.Drawing.Point(168, 23);
            this.pic_Unit_ReligiousStrength.Name = "pic_Unit_ReligiousStrength";
            this.pic_Unit_ReligiousStrength.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_ReligiousStrength.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_ReligiousStrength.TabIndex = 111;
            this.pic_Unit_ReligiousStrength.TabStop = false;
            // 
            // tbx_Unit_ReligiousStrength
            // 
            this.tbx_Unit_ReligiousStrength.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_ReligiousStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_ReligiousStrength.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_ReligiousStrength.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_ReligiousStrength.Location = new System.Drawing.Point(204, 27);
            this.tbx_Unit_ReligiousStrength.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_ReligiousStrength.Name = "tbx_Unit_ReligiousStrength";
            this.tbx_Unit_ReligiousStrength.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_ReligiousStrength.TabIndex = 106;
            this.tbx_Unit_ReligiousStrength.WordWrap = false;
            // 
            // chbx_Unit_FoundReligion
            // 
            this.chbx_Unit_FoundReligion.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_FoundReligion.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_FoundReligion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_FoundReligion.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_FoundReligion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_FoundReligion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_FoundReligion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_FoundReligion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_FoundReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_FoundReligion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_FoundReligion.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_FoundReligion.Image")));
            this.chbx_Unit_FoundReligion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_FoundReligion.Location = new System.Drawing.Point(8, 23);
            this.chbx_Unit_FoundReligion.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_FoundReligion.Name = "chbx_Unit_FoundReligion";
            this.chbx_Unit_FoundReligion.Size = new System.Drawing.Size(138, 27);
            this.chbx_Unit_FoundReligion.TabIndex = 73;
            this.chbx_Unit_FoundReligion.Text = "FoundReligion";
            this.chbx_Unit_FoundReligion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_FoundReligion.UseVisualStyleBackColor = true;
            this.chbx_Unit_FoundReligion.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_EvangelizeBelief
            // 
            this.chbx_Unit_EvangelizeBelief.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_EvangelizeBelief.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_EvangelizeBelief.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_EvangelizeBelief.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_EvangelizeBelief.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_EvangelizeBelief.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_EvangelizeBelief.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_EvangelizeBelief.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_EvangelizeBelief.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_EvangelizeBelief.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_EvangelizeBelief.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_EvangelizeBelief.Image")));
            this.chbx_Unit_EvangelizeBelief.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_EvangelizeBelief.Location = new System.Drawing.Point(8, 50);
            this.chbx_Unit_EvangelizeBelief.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_EvangelizeBelief.Name = "chbx_Unit_EvangelizeBelief";
            this.chbx_Unit_EvangelizeBelief.Size = new System.Drawing.Size(138, 27);
            this.chbx_Unit_EvangelizeBelief.TabIndex = 75;
            this.chbx_Unit_EvangelizeBelief.Text = "EvangelizeBelief";
            this.chbx_Unit_EvangelizeBelief.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_EvangelizeBelief.UseVisualStyleBackColor = true;
            this.chbx_Unit_EvangelizeBelief.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Unit_ReligionEvictPercent
            // 
            this.tbx_Unit_ReligionEvictPercent.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_ReligionEvictPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_ReligionEvictPercent.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_ReligionEvictPercent.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_ReligionEvictPercent.Location = new System.Drawing.Point(204, 70);
            this.tbx_Unit_ReligionEvictPercent.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_ReligionEvictPercent.Name = "tbx_Unit_ReligionEvictPercent";
            this.tbx_Unit_ReligionEvictPercent.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_ReligionEvictPercent.TabIndex = 107;
            this.tbx_Unit_ReligionEvictPercent.WordWrap = false;
            // 
            // chbx_Unit_LaunchInquisition
            // 
            this.chbx_Unit_LaunchInquisition.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_LaunchInquisition.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_LaunchInquisition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_LaunchInquisition.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_LaunchInquisition.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_LaunchInquisition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_LaunchInquisition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_LaunchInquisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_LaunchInquisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_LaunchInquisition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_LaunchInquisition.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_LaunchInquisition.Image")));
            this.chbx_Unit_LaunchInquisition.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_LaunchInquisition.Location = new System.Drawing.Point(8, 77);
            this.chbx_Unit_LaunchInquisition.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_LaunchInquisition.Name = "chbx_Unit_LaunchInquisition";
            this.chbx_Unit_LaunchInquisition.Size = new System.Drawing.Size(138, 27);
            this.chbx_Unit_LaunchInquisition.TabIndex = 76;
            this.chbx_Unit_LaunchInquisition.Text = "LaunchInquisition";
            this.chbx_Unit_LaunchInquisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_LaunchInquisition.UseVisualStyleBackColor = true;
            this.chbx_Unit_LaunchInquisition.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_RequiresInquisition
            // 
            this.chbx_Unit_RequiresInquisition.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_RequiresInquisition.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_RequiresInquisition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_RequiresInquisition.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_RequiresInquisition.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_RequiresInquisition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_RequiresInquisition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_RequiresInquisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_RequiresInquisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_RequiresInquisition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_RequiresInquisition.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_RequiresInquisition.Image")));
            this.chbx_Unit_RequiresInquisition.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_RequiresInquisition.Location = new System.Drawing.Point(8, 104);
            this.chbx_Unit_RequiresInquisition.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_RequiresInquisition.Name = "chbx_Unit_RequiresInquisition";
            this.chbx_Unit_RequiresInquisition.Size = new System.Drawing.Size(156, 27);
            this.chbx_Unit_RequiresInquisition.TabIndex = 77;
            this.chbx_Unit_RequiresInquisition.Text = "RequiresInquisition";
            this.chbx_Unit_RequiresInquisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_RequiresInquisition.UseVisualStyleBackColor = true;
            this.chbx_Unit_RequiresInquisition.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Unit_SpreadCharges
            // 
            this.tbx_Unit_SpreadCharges.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_SpreadCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_SpreadCharges.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_SpreadCharges.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_SpreadCharges.Location = new System.Drawing.Point(204, 113);
            this.tbx_Unit_SpreadCharges.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_SpreadCharges.Name = "tbx_Unit_SpreadCharges";
            this.tbx_Unit_SpreadCharges.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_SpreadCharges.TabIndex = 108;
            this.tbx_Unit_SpreadCharges.WordWrap = false;
            // 
            // chbx_Unit_TrackReligion
            // 
            this.chbx_Unit_TrackReligion.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_TrackReligion.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_TrackReligion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_TrackReligion.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_TrackReligion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_TrackReligion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_TrackReligion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_TrackReligion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_TrackReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_TrackReligion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_TrackReligion.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_TrackReligion.Image")));
            this.chbx_Unit_TrackReligion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_TrackReligion.Location = new System.Drawing.Point(8, 158);
            this.chbx_Unit_TrackReligion.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_TrackReligion.Name = "chbx_Unit_TrackReligion";
            this.chbx_Unit_TrackReligion.Size = new System.Drawing.Size(124, 27);
            this.chbx_Unit_TrackReligion.TabIndex = 92;
            this.chbx_Unit_TrackReligion.Text = "TrackReligion";
            this.chbx_Unit_TrackReligion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_TrackReligion.UseVisualStyleBackColor = true;
            this.chbx_Unit_TrackReligion.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // chbx_Unit_EnabledByReligion
            // 
            this.chbx_Unit_EnabledByReligion.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_Unit_EnabledByReligion.BackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_EnabledByReligion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_Unit_EnabledByReligion.FlatAppearance.BorderSize = 0;
            this.chbx_Unit_EnabledByReligion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_Unit_EnabledByReligion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_Unit_EnabledByReligion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_Unit_EnabledByReligion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_Unit_EnabledByReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_Unit_EnabledByReligion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chbx_Unit_EnabledByReligion.Image = ((System.Drawing.Image)(resources.GetObject("chbx_Unit_EnabledByReligion.Image")));
            this.chbx_Unit_EnabledByReligion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_Unit_EnabledByReligion.Location = new System.Drawing.Point(8, 131);
            this.chbx_Unit_EnabledByReligion.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_Unit_EnabledByReligion.Name = "chbx_Unit_EnabledByReligion";
            this.chbx_Unit_EnabledByReligion.Size = new System.Drawing.Size(159, 27);
            this.chbx_Unit_EnabledByReligion.TabIndex = 93;
            this.chbx_Unit_EnabledByReligion.Text = "EnabledByReligion";
            this.chbx_Unit_EnabledByReligion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_Unit_EnabledByReligion.UseVisualStyleBackColor = true;
            this.chbx_Unit_EnabledByReligion.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // tbx_Unit_ReligiousHealCharges
            // 
            this.tbx_Unit_ReligiousHealCharges.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Unit_ReligiousHealCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Unit_ReligiousHealCharges.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_Unit_ReligiousHealCharges.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbx_Unit_ReligiousHealCharges.Location = new System.Drawing.Point(204, 156);
            this.tbx_Unit_ReligiousHealCharges.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_Unit_ReligiousHealCharges.Name = "tbx_Unit_ReligiousHealCharges";
            this.tbx_Unit_ReligiousHealCharges.Size = new System.Drawing.Size(60, 24);
            this.tbx_Unit_ReligiousHealCharges.TabIndex = 109;
            this.tbx_Unit_ReligiousHealCharges.WordWrap = false;
            // 
            // pic_Unit_SpreadCharges
            // 
            this.pic_Unit_SpreadCharges.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_SpreadCharges.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_SpreadCharges.Image")));
            this.pic_Unit_SpreadCharges.Location = new System.Drawing.Point(168, 109);
            this.pic_Unit_SpreadCharges.Name = "pic_Unit_SpreadCharges";
            this.pic_Unit_SpreadCharges.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_SpreadCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_SpreadCharges.TabIndex = 113;
            this.pic_Unit_SpreadCharges.TabStop = false;
            // 
            // pic_Unit_ReligionEvictPercent
            // 
            this.pic_Unit_ReligionEvictPercent.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_ReligionEvictPercent.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_ReligionEvictPercent.Image")));
            this.pic_Unit_ReligionEvictPercent.Location = new System.Drawing.Point(168, 66);
            this.pic_Unit_ReligionEvictPercent.Name = "pic_Unit_ReligionEvictPercent";
            this.pic_Unit_ReligionEvictPercent.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_ReligionEvictPercent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_ReligionEvictPercent.TabIndex = 112;
            this.pic_Unit_ReligionEvictPercent.TabStop = false;
            // 
            // pic_Unit_ReligiousHealCharges
            // 
            this.pic_Unit_ReligiousHealCharges.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_ReligiousHealCharges.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_ReligiousHealCharges.Image")));
            this.pic_Unit_ReligiousHealCharges.Location = new System.Drawing.Point(168, 152);
            this.pic_Unit_ReligiousHealCharges.Name = "pic_Unit_ReligiousHealCharges";
            this.pic_Unit_ReligiousHealCharges.Size = new System.Drawing.Size(32, 32);
            this.pic_Unit_ReligiousHealCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Unit_ReligiousHealCharges.TabIndex = 114;
            this.pic_Unit_ReligiousHealCharges.TabStop = false;
            // 
            // CurrentUnit_Label
            // 
            this.CurrentUnit_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUnit_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.CurrentUnit_Label.Location = new System.Drawing.Point(0, 3);
            this.CurrentUnit_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentUnit_Label.Name = "CurrentUnit_Label";
            this.CurrentUnit_Label.Size = new System.Drawing.Size(273, 30);
            this.CurrentUnit_Label.TabIndex = 15;
            this.CurrentUnit_Label.Text = "Current Unit";
            this.CurrentUnit_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrentUnit_Label.Visible = false;
            // 
            // GridView_UnitReplaces
            // 
            this.GridView_UnitReplaces.AllowUserToAddRows = false;
            this.GridView_UnitReplaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView_UnitReplaces.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_UnitReplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_UnitReplaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gridview_UnitReplaces_Col_ReplacesUnitType});
            this.GridView_UnitReplaces.Location = new System.Drawing.Point(1157, 553);
            this.GridView_UnitReplaces.MultiSelect = false;
            this.GridView_UnitReplaces.Name = "GridView_UnitReplaces";
            this.GridView_UnitReplaces.RowHeadersVisible = false;
            this.GridView_UnitReplaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView_UnitReplaces.Size = new System.Drawing.Size(239, 78);
            this.GridView_UnitReplaces.TabIndex = 9;
            this.GridView_UnitReplaces.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllGridViews_SecondaryTables_CellMouseClick);
            // 
            // Gridview_UnitReplaces_Col_ReplacesUnitType
            // 
            this.Gridview_UnitReplaces_Col_ReplacesUnitType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gridview_UnitReplaces_Col_ReplacesUnitType.HeaderText = "ReplacesUnitType";
            this.Gridview_UnitReplaces_Col_ReplacesUnitType.Name = "Gridview_UnitReplaces_Col_ReplacesUnitType";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Units);
            this.tabControl1.Controls.Add(this.tab_UnitPromotions);
            this.tabControl1.Controls.Add(this.tab_Modifiers);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1651, 1022);
            this.tabControl1.TabIndex = 16;
            // 
            // chbx_AddNewTexts
            // 
            this.chbx_AddNewTexts.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_AddNewTexts.BackColor = System.Drawing.Color.Transparent;
            this.chbx_AddNewTexts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_AddNewTexts.FlatAppearance.BorderSize = 0;
            this.chbx_AddNewTexts.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chbx_AddNewTexts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.chbx_AddNewTexts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.chbx_AddNewTexts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_AddNewTexts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbx_AddNewTexts.ForeColor = System.Drawing.Color.Black;
            this.chbx_AddNewTexts.Image = ((System.Drawing.Image)(resources.GetObject("chbx_AddNewTexts.Image")));
            this.chbx_AddNewTexts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_AddNewTexts.Location = new System.Drawing.Point(1663, 222);
            this.chbx_AddNewTexts.Margin = new System.Windows.Forms.Padding(0);
            this.chbx_AddNewTexts.Name = "chbx_AddNewTexts";
            this.chbx_AddNewTexts.Size = new System.Drawing.Size(132, 27);
            this.chbx_AddNewTexts.TabIndex = 156;
            this.chbx_AddNewTexts.Text = "Add New Texts";
            this.chbx_AddNewTexts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbx_AddNewTexts.UseVisualStyleBackColor = true;
            this.chbx_AddNewTexts.CheckedChanged += new System.EventHandler(this.AllCheckboxes_CheckedChanged);
            // 
            // SaveLocalizedText_Button
            // 
            this.SaveLocalizedText_Button.Location = new System.Drawing.Point(1663, 179);
            this.SaveLocalizedText_Button.Name = "SaveLocalizedText_Button";
            this.SaveLocalizedText_Button.Size = new System.Drawing.Size(120, 23);
            this.SaveLocalizedText_Button.TabIndex = 157;
            this.SaveLocalizedText_Button.Text = "Save Localized Text";
            this.SaveLocalizedText_Button.UseVisualStyleBackColor = true;
            this.SaveLocalizedText_Button.Click += new System.EventHandler(this.SaveLocalizedText_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1804, 941);
            this.Controls.Add(this.SaveLocalizedText_Button);
            this.Controls.Add(this.chbx_AddNewTexts);
            this.Controls.Add(this.AddLocalizationFile_Btn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AddMainDatabase_Btn);
            this.Controls.Add(this.SaveFile_Button);
            this.Controls.Add(this.ResetTables_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tab_Modifiers.ResumeLayout(false);
            this.Panel_Table_Requirements.ResumeLayout(false);
            this.Panel_Table_Requirements.PerformLayout();
            this.Panel_Table_Modifiers.ResumeLayout(false);
            this.Panel_Table_Modifiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_RequirementArguments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_RequirementSetRequirements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_RequirementSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Requirements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ModifierArguments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Modifiers)).EndInit();
            this.tab_UnitPromotions.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitPromotionPrereqs)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitPromotionClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitPromotions)).EndInit();
            this.tab_Units.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Unit_BuildingPrereqs)).EndInit();
            this.Panel_Table_UnitAbilities.ResumeLayout(false);
            this.Panel_Table_UnitAbilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_AbilityTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitAbilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitAiInfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Units)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitUpgrades)).EndInit();
            this.Panel_Table_Units.ResumeLayout(false);
            this.Panel_Table_Units.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Maintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_XP2_ResourceMaintenanceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_XP2_ResourceMaintenanceType)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_TraitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PseudoYieldType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_NumRandomChoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Unit_TraitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_AdvisorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_LeaderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_LeaderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PseudoYieldType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_AdvisorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_BuildCharges)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_MandatoryObsoleteCivic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_MandatoryObsoleteTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_MandatoryObsoleteCivic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_MandatoryObsoleteTech)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_ObsoleteCivic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_ObsoleteTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ObsoleteTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ObsoleteCivic)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PrereqDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PrereqCivic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PrereqTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqCivic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PrereqPopulation)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_CostProgressionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PurchaseYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Unit_CostProgressionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_StrategicResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PurchaseYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_StrategicResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PopulationCost)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_PromotionClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_InitialLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Unit_Flavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_FormationClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_AirSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_FormationClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Unit_Domain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Domain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_PromotionClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Combat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_RangedCombat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_BaseMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_BaseSightRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Bombard)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ReligiousStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_SpreadCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ReligionEvictPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_ReligiousHealCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_UnitReplaces)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMainDatabase_Btn;
        private System.Windows.Forms.Button SaveFile_Button;
        private System.Windows.Forms.Button ResetTables_Btn;
        private System.Windows.Forms.Button AddLocalizationFile_Btn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearPromotionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tab_Modifiers;
        private System.Windows.Forms.Button AddRequirementArgument_Btn;
        private System.Windows.Forms.Button AddModifierArgument_Btn;
        private System.Windows.Forms.Label CurrentRequirement_Label;
        private System.Windows.Forms.Label CurrentModifier_Label;
        private System.Windows.Forms.Button AddRequirementSetRequirement_Btn;
        private System.Windows.Forms.Button AddRequirementSet_Btn;
        private System.Windows.Forms.Button AddRequirement_Btn;
        private System.Windows.Forms.Panel Panel_Table_Requirements;
        private System.Windows.Forms.Label lbl_Requirement_RequirementType;
        private System.Windows.Forms.Label lbl_Requirement_Likeliness;
        private System.Windows.Forms.TextBox tbx_Requirement_ProgressWeight;
        private System.Windows.Forms.Label lbl_Requirement_Impact;
        private System.Windows.Forms.ComboBox cbx_Requirement_RequirementType;
        private System.Windows.Forms.TextBox tbx_Requirement_Likeliness;
        private System.Windows.Forms.Label lbl_Requirement_ProgressWeight;
        private System.Windows.Forms.TextBox tbx_Requirement_Impact;
        private System.Windows.Forms.Button AddModifier_Btn;
        private System.Windows.Forms.Label Label_Modifiers;
        private System.Windows.Forms.Label Label_ModifierArguments;
        private System.Windows.Forms.Label Label_RequirementArguments;
        private System.Windows.Forms.Label Label_Requirements;
        private System.Windows.Forms.Label Label_RequirementSetRequirements;
        private System.Windows.Forms.Label Label_RequirementSets;
        private System.Windows.Forms.Panel Panel_Table_Modifiers;
        private System.Windows.Forms.Label lbl_Modifier_Subject;
        private System.Windows.Forms.Label lbl_Modifier_Owner;
        private System.Windows.Forms.Label lbl_Modifier_StackLimit;
        private System.Windows.Forms.Label lbl_Modifier_RequirementSetID;
        private System.Windows.Forms.Label lbl_Modifier_ModifierType;
        private System.Windows.Forms.ComboBox cbx_Modifier_ModifierType;
        private System.Windows.Forms.TextBox tbx_Modifier_SubjectStackLimit;
        private System.Windows.Forms.ComboBox cbx_Modifier_SubjectRequirementSetID;
        private System.Windows.Forms.TextBox tbx_Modifier_OwnerStackLimit;
        private System.Windows.Forms.ComboBox cbx_Modifier_OwnerRequirementSetID;
        private System.Windows.Forms.CheckBox chbx_Modifier_Permanent;
        private System.Windows.Forms.DataGridView GridView_RequirementArguments;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementArguments_Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementArguments_Col_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementArguments_Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementArguments_Col_Extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementArguments_Col_SecondExtra;
        private System.Windows.Forms.DataGridView GridView_RequirementSetRequirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementSetRequirements_Col_RequirementID;
        private System.Windows.Forms.DataGridView GridView_RequirementSets;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_RequirementSets_Col_RequirementSetID;
        private System.Windows.Forms.DataGridViewComboBoxColumn GV_RequirementSets_Col_RequirementSetType;
        private System.Windows.Forms.DataGridView GridView_Requirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_Requirements_Col_RequirementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_Requirements_Col_RequirementType;
        private System.Windows.Forms.DataGridView GridView_ModifierArguments;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ModifierArguments_Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ModifierArguments_Col_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ModifierArguments_Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ModifierArguments_Col_Extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ModifierArguments_Col_SecondExtra;
        private System.Windows.Forms.DataGridView GridView_Modifiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_Modifiers_Col_ModifierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_Modifiers_Col_ModifierType;
        private System.Windows.Forms.TabPage tab_UnitPromotions;
        private System.Windows.Forms.DataGridView GridView_UnitPromotionPrereqs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridView_UnitPromotionClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotionClasses_Col_PromotionClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotionClasses_Col_Name;
        private System.Windows.Forms.DataGridView GridView_UnitPromotions;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_UnitPromotionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_PromotionClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotions_Col_Column;
        private System.Windows.Forms.Panel Panel_PromotionClassPromotions;
        private System.Windows.Forms.TabPage tab_Units;
        private System.Windows.Forms.Button AddUnit_Btn;
        private System.Windows.Forms.DataGridView GridView_UnitAbilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAbilities_Col_UnitAbilityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAbilities_Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAbilities_Col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAbilities_Col_Inactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAbilities_Col_ShowFloatTextWhenEarned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAbilities_Col_Permanent;
        private System.Windows.Forms.DataGridView GridView_UnitTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_TypeTags_Col_Tag;
        private System.Windows.Forms.Label CurrentUnit_Label;
        private System.Windows.Forms.DataGridView GridView_UnitAiInfos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitAiInfos_Col_AiType;
        private System.Windows.Forms.DataGridView GridView_Units;
        private System.Windows.Forms.DataGridView GridView_UnitUpgrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitUpgrades_Col_UpgradeUnit;
        private System.Windows.Forms.Panel Panel_Table_Units;
        private System.Windows.Forms.TextBox tbx_Unit_RangedCombat;
        private System.Windows.Forms.TextBox tbx_Unit_Combat;
        private System.Windows.Forms.DataGridView GridView_UnitReplaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_UnitReplaces_Col_ReplacesUnitType;
        private System.Windows.Forms.DataGridView GridView_Unit_BuildingPrereqs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_Unit_BuildingPrereqs_Col_PrereqBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gridview_Unit_BuildingPrereqs_Col_NumSupported;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnitPromotionPrereqs_Col_PrereqUnitPromotion;
        private System.Windows.Forms.Button AddUnitPromotionClasse_Btn;
        private System.Windows.Forms.Button AddUnitPromotion_Btn;
        private System.Windows.Forms.Label CurrentPromotionClass_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUnit_BuildingPrereq_Btn;
        private System.Windows.Forms.Button AddUnitAbilitie_Btn;
        private System.Windows.Forms.Button AddUnitReplace_Btn;
        private System.Windows.Forms.Button AddUnitAiInfo_Btn;
        private System.Windows.Forms.Button AddUnitUpgrade_Btn;
        private System.Windows.Forms.Button AddUnitTag_Btn;
        private System.Windows.Forms.DataGridView GridView_AbilityTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button AddAbilityTag_Btn;
        private System.Windows.Forms.PictureBox pic_Unit_Combat;
        private System.Windows.Forms.PictureBox pic_Unit_RangedCombat;
        private System.Windows.Forms.TextBox tbx_Unit_PopulationCost;
        private System.Windows.Forms.PictureBox pic_Unit_Cost;
        private System.Windows.Forms.TextBox tbx_Unit_Cost;
        private System.Windows.Forms.PictureBox pic_Unit_Bombard;
        private System.Windows.Forms.TextBox tbx_Unit_Bombard;
        private System.Windows.Forms.PictureBox pic_Unit_BaseSightRange;
        private System.Windows.Forms.TextBox tbx_Unit_BaseSightRange;
        private System.Windows.Forms.PictureBox pic_Unit_Range;
        private System.Windows.Forms.TextBox tbx_Unit_Range;
        private System.Windows.Forms.PictureBox pic_Unit_BaseMoves;
        private System.Windows.Forms.TextBox tbx_Unit_BaseMoves;
        private System.Windows.Forms.CheckBox chbx_Requirement_Triggered1;
        private System.Windows.Forms.CheckBox chbx_Requirement_Persistent1;
        private System.Windows.Forms.CheckBox chbx_Requirement_Reverse1;
        private System.Windows.Forms.CheckBox chbx_Requirement_Inverse1;
        private System.Windows.Forms.CheckBox chbx_Modifier_NewOnly;
        private System.Windows.Forms.CheckBox chbx_Modifier_RunOnce;
        private System.Windows.Forms.CheckBox chbx_Modifier_Repeatable;
        private System.Windows.Forms.ImageList IconsGeneral_ImageList;
        private System.Windows.Forms.CheckBox chbx_Unit_FoundCity;
        private System.Windows.Forms.CheckBox chbx_Unit_FoundReligion;
        private System.Windows.Forms.CheckBox chbx_Unit_AllowBarbarians;
        private System.Windows.Forms.CheckBox chbx_Unit_CanRetreatWhenCaptured;
        private System.Windows.Forms.CheckBox chbx_Unit_CanCapture;
        private System.Windows.Forms.CheckBox chbx_Unit_ExtractsArtifacts;
        private System.Windows.Forms.CheckBox chbx_Unit_RequiresInquisition;
        private System.Windows.Forms.CheckBox chbx_Unit_LaunchInquisition;
        private System.Windows.Forms.CheckBox chbx_Unit_EvangelizeBelief;
        private System.Windows.Forms.CheckBox chbx_Unit_MakeTradeRoute;
        private System.Windows.Forms.CheckBox chbx_Unit_Spy;
        private System.Windows.Forms.CheckBox chbx_Unit_ZoneOfControl;
        private System.Windows.Forms.CheckBox chbx_Unit_CanTargetAir;
        private System.Windows.Forms.CheckBox chbx_Unit_Stackable;
        private System.Windows.Forms.CheckBox chbx_Unit_MustPurchase;
        private System.Windows.Forms.CheckBox chbx_Unit_CanTrain;
        private System.Windows.Forms.CheckBox chbx_Unit_ImmediatelyName;
        private System.Windows.Forms.CheckBox chbx_Unit_EnabledByReligion;
        private System.Windows.Forms.CheckBox chbx_Unit_TrackReligion;
        private System.Windows.Forms.CheckBox chbx_Unit_TeamVisibility;
        private System.Windows.Forms.CheckBox chbx_Unit_IgnoreMoves;
        private System.Windows.Forms.CheckBox chbx_Unit_WMDCapable;
        private System.Windows.Forms.CheckBox chbx_Unit_CanEarnExperience;
        private System.Windows.Forms.CheckBox chbx_Unit_UseMaxMeleeTrainedStrength;
        private System.Windows.Forms.TextBox tbx_Unit_PrereqPopulation;
        private System.Windows.Forms.PictureBox pic_Unit_PrereqPopulation;
        private System.Windows.Forms.PictureBox pic_Unit_PrereqDistrict;
        private System.Windows.Forms.PictureBox pic_Unit_PrereqCivic;
        private System.Windows.Forms.PictureBox pic_Unit_PrereqTech;
        private System.Windows.Forms.PictureBox pic_Unit_PopulationCost;
        private System.Windows.Forms.PictureBox pic_Unit_ReligiousHealCharges;
        private System.Windows.Forms.PictureBox pic_Unit_SpreadCharges;
        private System.Windows.Forms.PictureBox pic_Unit_ReligionEvictPercent;
        private System.Windows.Forms.PictureBox pic_Unit_ReligiousStrength;
        private System.Windows.Forms.PictureBox pic_Unit_BuildCharges;
        private System.Windows.Forms.TextBox tbx_Unit_ReligiousHealCharges;
        private System.Windows.Forms.TextBox tbx_Unit_SpreadCharges;
        private System.Windows.Forms.TextBox tbx_Unit_ReligionEvictPercent;
        private System.Windows.Forms.TextBox tbx_Unit_ReligiousStrength;
        private System.Windows.Forms.TextBox tbx_Unit_BuildCharges;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label_UnitAbilities;
        private System.Windows.Forms.TextBox tbx_Unit_DisasterCharges;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pic_Unit_ObsoleteTech;
        private System.Windows.Forms.PictureBox pic_Unit_ObsoleteCivic;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pic_Unit_MandatoryObsoleteCivic;
        private System.Windows.Forms.PictureBox pic_Unit_MandatoryObsoleteTech;
        private System.Windows.Forms.TextBox tbx_Unit_AirSlots;
        private System.Windows.Forms.TextBox tbx_Unit_Maintenance;
        private System.Windows.Forms.CheckBox chbx_Unit_XP2_CanSacrificeUnits;
        private System.Windows.Forms.CheckBox chbx_Unit_XP2_CanCauseDisasters;
        private System.Windows.Forms.CheckBox chbx_Unit_XP2_MajorCivOnly;
        private System.Windows.Forms.CheckBox chbx_Unit_XP2_TourismBombPossible;
        private System.Windows.Forms.CheckBox chbx_Unit_XP2_CanFormMilitaryFormation;
        private System.Windows.Forms.CheckBox chbx_Unit_XP2_CanEarnExperience;
        private System.Windows.Forms.TextBox tbx_Unit_XP2_TourismBomb;
        private System.Windows.Forms.TextBox tbx_Unit_XP2_ResourceMaintenanceAmount;
        private System.Windows.Forms.TextBox tbx_Unit_XP2_ResourceCost;
        private System.Windows.Forms.PictureBox pic_Unit_StrategicResource;
        private System.Windows.Forms.PictureBox pic_Unit_Maintenance;
        private System.Windows.Forms.PictureBox pic_Unit_PurchaseYield;
        private System.Windows.Forms.PictureBox pic_Unit_XP2_ResourceMaintenanceType;
        private System.Windows.Forms.PictureBox pic_Unit_PromotionClass;
        private System.Windows.Forms.PictureBox pic_Unit_AirSlots;
        private System.Windows.Forms.PictureBox pic_Unit_PseudoYieldType;
        private System.Windows.Forms.PictureBox pic_Unit_AdvisorType;
        private System.Windows.Forms.PictureBox pic_Unit_LeaderType;
        private System.Windows.Forms.PictureBox pic_Unit_FormationClass;
        private System.Windows.Forms.PictureBox pic_Unit_Domain;
        private System.Windows.Forms.GroupBox groupBox8;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_PrereqTech;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_MandatoryObsoleteCivic;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_MandatoryObsoleteTech;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_ObsoleteCivic;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_ObsoleteTech;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_PrereqDistrict;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_PrereqCivic;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_Domain;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_PseudoYieldType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_AdvisorType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_LeaderType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_XP2_ResourceMaintenanceType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_PurchaseYield;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_StrategicResource;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_PromotionClass;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_Unit_FormationClass;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox tbx_Unit_Flavor;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox tbx_Unit_TraitType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox tbx_Unit_CostProgressionModel;
        private System.Windows.Forms.TextBox tbx_Unit_CostProgressionParam1;
        private System.Windows.Forms.TextBox tbx_Unit_NumRandomChoices;
        private System.Windows.Forms.TextBox tbx_Unit_InitialLevel;
        private System.Windows.Forms.PictureBox pic_Unit_TraitType;
        private System.Windows.Forms.PictureBox pic_Unit_NumRandomChoices;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pic_Unit_InitialLevel;
        private System.Windows.Forms.PictureBox pic_Unit_CostProgressionModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbx_Loc_Unit_Description;
        private ZBobb.AlphaBlendTextBox tbx_Loc_Unit_Name;
        private System.Windows.Forms.RichTextBox tbx_Loc_Abilitie_Description;
        private ZBobb.AlphaBlendTextBox tbx_Loc_Abilitie_Name;
        private System.Windows.Forms.Panel Panel_Table_UnitAbilities;
        private System.Windows.Forms.CheckBox chbx_Abilitie_Permanent;
        private System.Windows.Forms.CheckBox chbx_Abilitie_ShowFloatTextWhenEarned;
        private System.Windows.Forms.CheckBox chbx_Abilitie_Inactive;
        private System.Windows.Forms.CheckBox chbx_ShowAbilitiesTags;
        private System.Windows.Forms.CheckBox chbx_AddNewTexts;
        private System.Windows.Forms.Button SaveLocalizedText_Button;
    }
}

