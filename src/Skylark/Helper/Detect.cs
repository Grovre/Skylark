﻿namespace Skylark.Helper
{
    internal class Detect
    {
        public static char Symbol()
        {
            if ($"{10 / 3f}".Contains('.'))
            {
                return '.';
            }
            else
            {
                return ',';
            }
        }
    }
}