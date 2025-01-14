namespace AutoVisor;

public static class Offsets
{
    public static class Character
    {
        public const int Hat                = 0x808;
        public const int HatVisible         = 0x84E;
        public const int VisorToggled       = 0x84F;
        public const int WeaponDrawn        = 0x1AD6;
        public const int WeaponHidden1      = 0x84F;
        public const int SeatingState = 0x1ABD;
        public const int CPose        = 0x631;

        public static class Flags
        {
            public const byte IsHatHidden     = 0x01;
            public const byte IsVisorToggled  = 0x08;
            public const byte IsWeaponDrawn   = 0x04;
            public const byte IsWeaponHidden1 = 0x01;
        }
    }

    public static class Meta
    {
        public static class Flags
        {
            public const uint GimmickVisorEnabled  = 0b01;
            public const uint GimmickVisorAnimated = 0b10;

            public const ulong EqpHatHrothgar = 0x0100000000000000;
            public const ulong EqpHatViera    = 0x0200000000000000;
        }
    }
}
