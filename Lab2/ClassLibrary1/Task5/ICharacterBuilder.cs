using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task5
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetBody(string body);
        ICharacterBuilder SetHair(string hair);
        ICharacterBuilder SetEyes(string eyes);
        ICharacterBuilder AddClothes(string clothes);
        ICharacterBuilder AddItem(string item);

        Character Build();
    }
}
