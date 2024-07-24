using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.FactoryMethodSystemSavingFiles
{
    abstract class TypeDocument
    {
        private String fileType;
        public String FileType
        {
            get
            {
                return fileType;    // возвращаем значение свойства
            }
            set
            {
                fileType = value;   // устанавливаем новое значение свойства
            }
        }
    }
}
