using System.Collections.Generic;

namespace MaterialDesignLite.TagHelpers.StyleValues
{

    public class MDLColor
    {
        internal MDLColor(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }

        public class SpectrumMDLColor : MDLColor
    {
        internal SpectrumMDLColor(string name, string spectrum = null) : base(name)
        {
            Spectrum = spectrum;
        }

        public string Spectrum {get;}

        public virtual IEnumerable<SpectrumMDLColor> AllSpectrums
        {
            get
            {
                yield return WithBritghness50;
                yield return WithBritghness100;
                yield return WithBritghness200;
                yield return WithBritghness300;
                yield return WithBritghness400;
                yield return WithBritghness500;
                yield return WithBritghness600;
                yield return WithBritghness700;
                yield return WithBritghness800;
                yield return WithBritghness900;
               
            }
        }

        public SpectrumMDLColor WithBritghness50    { get { return new SpectrumMDLColor(Name, "50");} }
        public SpectrumMDLColor WithBritghness100   { get { return new SpectrumMDLColor(Name, "100");} }
        public SpectrumMDLColor WithBritghness200   { get { return new SpectrumMDLColor(Name, "200");} }
        public SpectrumMDLColor WithBritghness300   { get { return new SpectrumMDLColor(Name, "300");} }
        public SpectrumMDLColor WithBritghness400   { get { return new SpectrumMDLColor(Name, "400");} }
        public SpectrumMDLColor WithBritghness500   { get { return new SpectrumMDLColor(Name, "500");} }
        public SpectrumMDLColor WithBritghness600   { get { return new SpectrumMDLColor(Name, "600");} }
        public SpectrumMDLColor WithBritghness700   { get { return new SpectrumMDLColor(Name, "700");} }
        public SpectrumMDLColor WithBritghness800   { get { return new SpectrumMDLColor(Name, "800");} }
        public SpectrumMDLColor WithBritghness900   { get { return new SpectrumMDLColor(Name, "900");} }
        
        public override string ToString()
        {
            string val = Name;
            if (!string.IsNullOrEmpty(Spectrum))
            {
                val += $"-{Spectrum}";
            }

            return val;
        }
    }

     public class SpectrumAlphaMDLColor : SpectrumMDLColor
    {
        internal SpectrumAlphaMDLColor(string name, string spectrum = null) : base(name,spectrum)
        {
          
        }

        public override IEnumerable<SpectrumMDLColor> AllSpectrums
        {
            get
            {
                yield return WithBritghness50;
                yield return WithBritghness100;
                yield return WithBritghness200;
                yield return WithBritghness300;
                yield return WithBritghness400;
                yield return WithBritghness500;
                yield return WithBritghness600;
                yield return WithBritghness700;
                yield return WithBritghness800;
                yield return WithBritghness900;
                yield return WithAlpha100;
                yield return WithAlpha200;
                yield return WithAlpha400;
                yield return WithAlpha700;
            }
        }

        public SpectrumAlphaMDLColor WithAlpha100        { get { return new SpectrumAlphaMDLColor(Name, "A100");} }
        public SpectrumAlphaMDLColor WithAlpha200        { get { return new SpectrumAlphaMDLColor(Name, "A200");} }
        public SpectrumAlphaMDLColor WithAlpha400        { get { return new SpectrumAlphaMDLColor(Name, "A400");} }
        public SpectrumAlphaMDLColor WithAlpha700        { get { return new SpectrumAlphaMDLColor(Name, "A700"); } }

    }

    public class MDLColors
    {
        private static Dictionary<string, MDLColor> _allColors = new Dictionary<string, MDLColor>
        {
            { "red",new SpectrumAlphaMDLColor("red") },
            { "pink",new SpectrumAlphaMDLColor("pink") },
            { "purple",new SpectrumAlphaMDLColor("purple") },
             { "deep-purple",new SpectrumAlphaMDLColor("deep-purple") },
            { "indigo",new SpectrumAlphaMDLColor("indigo") },
            { "blue",new SpectrumAlphaMDLColor("blue") },
            { "light-blue",new SpectrumAlphaMDLColor("light-blue") },
            { "cyan",new SpectrumAlphaMDLColor("cyan") },
            { "teal",new SpectrumAlphaMDLColor("teal") },
            { "green",new SpectrumAlphaMDLColor("green") },
            { "light-green",new SpectrumAlphaMDLColor("light-green") },
            { "lime",new SpectrumAlphaMDLColor("lime") },
            { "yellow",new SpectrumAlphaMDLColor("yellow") },
            { "amber",new SpectrumAlphaMDLColor("amber") },
            { "orange",new SpectrumAlphaMDLColor("orange") },
            { "deep-orange",new SpectrumAlphaMDLColor("deep-orange") },
            { "brown",new SpectrumMDLColor("brown") },
            { "grey",new SpectrumMDLColor("grey") },
            { "blue-grey",new SpectrumMDLColor("blue-grey") },

            { "white",new MDLColor("white") },
            { "black",new MDLColor("black") },
            { "Primary",new MDLColor("primary") },
            { "Primary-contrast",new MDLColor("primary-contrast") },
            { "Primary-dark",new MDLColor("primary-dark") },
            { "Accent",new MDLColor("accent") },
            { "Accent-contrast",new MDLColor("accent-contrast") },
        };

        public static IEnumerable<MDLColor> All { get { return _allColors.Values; } }

        public static SpectrumAlphaMDLColor Indigo   { get { return (SpectrumAlphaMDLColor)_allColors["indigo"]; } }
        public static SpectrumAlphaMDLColor Red      { get { return (SpectrumAlphaMDLColor)_allColors["red"]; } }
        public static SpectrumAlphaMDLColor Pink     { get { return (SpectrumAlphaMDLColor)_allColors["pink"]; } }
        public static SpectrumAlphaMDLColor Purple   { get { return (SpectrumAlphaMDLColor)_allColors["purple"]; } }
        public static SpectrumAlphaMDLColor DeepPurple{ get { return(SpectrumAlphaMDLColor)_allColors["deep-purple"]; } }
        public static SpectrumAlphaMDLColor Blue     { get { return (SpectrumAlphaMDLColor)_allColors["blue"]; } }
        public static SpectrumAlphaMDLColor LightBlue{ get { return (SpectrumAlphaMDLColor)_allColors["light-blue"]; } }
        public static SpectrumAlphaMDLColor Cyan     { get { return (SpectrumAlphaMDLColor)_allColors["cyan"]; } }
        public static SpectrumAlphaMDLColor Teal     { get { return (SpectrumAlphaMDLColor)_allColors["teal"]; } }
        public static SpectrumAlphaMDLColor Green    { get { return (SpectrumAlphaMDLColor)_allColors["green"]; } }
        public static SpectrumAlphaMDLColor LightGreen{ get { return(SpectrumAlphaMDLColor)_allColors["light-green"]; } }
        public static SpectrumAlphaMDLColor Lime     { get { return (SpectrumAlphaMDLColor)_allColors["lime"]; } }
        public static SpectrumAlphaMDLColor Yellow   { get { return (SpectrumAlphaMDLColor)_allColors["yellow"]; } }
        public static SpectrumAlphaMDLColor Amber    { get { return (SpectrumAlphaMDLColor)_allColors["amber"]; } }
        public static SpectrumAlphaMDLColor Orange   { get { return (SpectrumAlphaMDLColor)_allColors["orange"]; } }
        public static SpectrumAlphaMDLColor DeepOrange { get { return (SpectrumAlphaMDLColor)_allColors["deep-orange"]; } }
        public static SpectrumMDLColor Brown    { get { return (SpectrumMDLColor)_allColors["brown"]; } }
        public static SpectrumMDLColor Grey     { get { return (SpectrumMDLColor)_allColors["grey"]; } }
        public static SpectrumMDLColor BlueGrey { get { return (SpectrumMDLColor)_allColors["blue-grey"]; } }
               
        public static MDLColor White { get { return _allColors["white"]; } }
        public static MDLColor Black { get { return _allColors["black"]; } }
        public static MDLColor Primary { get { return _allColors["Primary"]; } }
        public static MDLColor PrimaryContrast { get { return _allColors["Primary-contrast"]; } }
        public static MDLColor PrimaryDark { get { return _allColors["Primary-dark"]; } }
        public static MDLColor Accent { get { return _allColors["Accent"]; } }
        public static MDLColor AccentContrast { get { return _allColors["Accent-contrast"]; } }
    }
}
