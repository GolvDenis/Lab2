using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public ICharacterBuilder SetHeight(int height)
        {
            character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBody(string body)
        {
            character.Body = body;
            return this;
        }

        public ICharacterBuilder SetHair(string hair)
        {
            character.Hair = hair;
            return this;
        }

        public ICharacterBuilder SetEyes(string eyes)
        {
            character.Eyes = eyes;
            return this;
        }

        public ICharacterBuilder AddClothes(string clothes)
        {
            character.Clothes.Add("Dark " + clothes);
            return this;
        }

        public ICharacterBuilder AddItem(string item)
        {
            character.Items.Add("Cursed " + item);
            return this;
        }

        public Character Build()
        {
            return character;
        }
    }
}
