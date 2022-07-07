using System;
using System.Collections.Generic;
using System.Text;


namespace TestProject1
{
    public partial class InputType0Command
    {
        public int Wash_Category { get; set; }
        public int Initial_Volume { get; set; }
        public int Flow_Rate { get; set; }

        private void ParseCommand()
        {
            if (this.IsInputLongEnough())
            {
                this.Parse_TypeId();
                this.Parse_Wash_Category();
                // ...
            }
        }

        private bool IsInputLongEnough()
        {
            if ($"{this.InputString}".Length < 10)
            {
                this.AddError("Length too short.");
                return false;
            }
            else return true;
        }


        private void Parse_TypeId()
        {
            // TODO: Still need to write the parse method for TypeId
        }

        private void Parse_Wash_Category()
        {
            var parsedWash_CategoryStr = this.InputString.Substring(1, 3);
            var parsedWash_Category = Int32.Parse(parsedWash_CategoryStr);
            if ((parsedWash_Category < 1) || (parsedWash_Category > 50))
            {
                this.AddError($"Wash_Category {parsedWash_Category} is outside of valid rante [{1}..{50}]");
            }
            this.Wash_Category = parsedWash_Category;
        }
    
        // TODO: still need to write the rest of the parse methods
    }
}

