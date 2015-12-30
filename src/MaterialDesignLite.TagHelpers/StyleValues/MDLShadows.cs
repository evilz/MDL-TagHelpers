using System.Collections.Generic;

namespace MaterialDesignLite.TagHelpers.StyleValues
{
    public struct MdlShadow
    {
        internal MdlShadow(int deep)
        {
            Deep = deep;
        }
        public int Deep { get; }

        public override string ToString()
        {
            return $"mdl-shadow--{Deep}dp";
        }
    }

    public static class MdlShadows
    {
        public static IEnumerable<MdlShadow> All
        {
            get
            {
                yield return Dp2;
                yield return Dp3;
                yield return Dp4;
                yield return Dp6;
                yield return Dp8;
                yield return Dp16;
            }
        }

        public static MdlShadow None => new MdlShadow(0);
        public static MdlShadow Dp2 => new MdlShadow(2);
        public static MdlShadow Dp3 => new MdlShadow(3);
        public static MdlShadow Dp4 => new MdlShadow(4);
        public static MdlShadow Dp6 => new MdlShadow(6);
        public static MdlShadow Dp8 => new MdlShadow(8);
        public static MdlShadow Dp16 => new MdlShadow(16);
    }
}
