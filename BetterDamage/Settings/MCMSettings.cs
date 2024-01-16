using BetterDamage.Localizations;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterDamage.Settings {

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {


        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.UndefinedText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float UndefinedAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.DaggerText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float DaggerAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedSwordText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float OneHandedSwordAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedSwordText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float TwoHandedSwordAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedAxeText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float OneHandedAxeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedAxeText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float TwoHandedAxeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.MaceText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float MaceAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.PickText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float PickAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedMaceText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float TwoHandedMaceAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.OneHandedPolearmText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float OneHandedPolearmAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.TwoHandedPolearmText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float TwoHandedPolearmAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.LowGripPolearmText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float LowGripPolearmAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.ArrowText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float ArrowAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.BoltText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float BoltAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.CartridgeText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float CartridgeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.BowText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float BowAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.CrossboxText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float CrossbowAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.StoneText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float StoneAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.BoulderText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float BoulderAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingAxeText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float ThrowingAxeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.ThrowingKnifeText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float ThrowingKnifeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.JavelinText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float JavelinAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.PistolText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float PistolAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.MusketText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float MusketAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.SmallShiledText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float SmallShieldAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.LargeShieldText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float LargeShieldAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.BannerText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float BannerAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.DamageAdjText)]
        [SettingPropertyFloatingInteger(RefValues.NumClassText, 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.GenericHint)]
        public float NumClassesAdjustment { get; set; } = 1f;

        [SettingPropertyGroup(RefValues.MiscText)]
        [SettingPropertyBool(RefValues.WepHelperText, Order = 1, RequireRestart = false, HintText = RefValues.WepHelperHint)]
        public bool WepClassHelper { get; set; } = false;

        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;
    }
}
