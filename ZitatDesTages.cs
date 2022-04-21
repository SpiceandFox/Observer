using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ZitatDesTages : AbstractZitatSubject
    {
        private string zitatText = "";

        public string GetZitat()
        {
            return this.zitatText;
        }
        public void SetZitat(string zitat)
        {
            this.zitatText = zitat;
            Notify();
        }
    }
}
