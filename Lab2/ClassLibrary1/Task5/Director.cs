using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task5
{
    public class Director
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(180)
                .SetBody("Athletic")
                .SetHair("Blonde")
                .SetEyes("Blue")
                .AddClothes("Armor")
                .AddItem("Sword")
                .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(190)
                .SetBody("Massive")
                .SetHair("Black")
                .SetEyes("Red")
                .AddClothes("Robe")
                .AddItem("Staff")
                .Build();
        }
    }
}
