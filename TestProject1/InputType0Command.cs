using System;

namespace TestProject1
{
    public partial class InputType0Command : BaseCommand
    {
        public InputType0Command(string inputString)
        {
            this.InputString = inputString;
            this.ParseCommand();
        }
    }
}