using System.Collections.Generic;

namespace ConversorNumerosRomanos
{
    public class Algarismos
    {
        public Dictionary<int, string> valoresConversao = new Dictionary<int, string>()
        {
            { 10000, "x̄"    },
            { 9000 , "īx̄"   },
            { 8000 , "v̄īīī" },
            { 7000 , "v̄īī"  },
            { 6000 , "v̄ī"   },
            { 5000 , "v̄"    },
            { 4000 , "īv̄"   },
            { 1000 , "m"    },
            { 900  , "cm"   },
            { 500  , "d"    },
            { 400  , "cd"   },
            { 100  , "c"    },
            { 90   , "xc"   },
            { 50   , "l"    },
            { 40   , "xl"   },
            { 10   , "x"    },
            { 9    , "ix"   },
            { 5    , "v"    },
            { 4    , "iv"   },
            { 1    , "i"    },
        };

        public Dictionary<string, int> dicionarioConversao = new Dictionary<string, int>()
        {
            { "X̄", 10000 },
            { "V̄", 5000 },
            { "m", 1000 },
            { "d", 500 },
            { "c", 100 },
            { "l", 50 },
            { "x", 10},
            { "v", 5},
            { "i", 1},
        };


    }
}
