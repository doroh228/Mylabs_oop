using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    class Bouquet : flower
    {
        public Bouquet(Plans flower1, Plans flower2)
        {
            Name = ((flower)flower1).Name + ", " + ((flower)flower2).Name;
            Color = ((flower)flower1).Color+"-"+ ((Gladiolus)flower2).colors;
            HowMuch = ((flower)flower1).HowMuch+ ((flower)flower2).HowMuch;
        }
        
        public override void DoClone()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Цвет букета: {Color}, цветы входящие в букет: {Name}; Цена букета: {HowMuch}";
        }
    }
}
