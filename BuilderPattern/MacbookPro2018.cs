using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class MacbookPro2018 : MacbookProBuilder
    {
        public override MacbookProBuilder BuildCPU(Processor processor)
        {
            macbookPro.Processor = processor;
            return this;
        }

        public override MacbookProBuilder BuildGraphics(Graphics graphics)
        {
            macbookPro.Graphics = graphics;
            return this;
        }

        public override MacbookProBuilder BuildKeyboard(Keyboard language)
        {
            macbookPro.Keyboard = language;
            return this;
        }

        public override MacbookProBuilder BuildMemory(Memory size)
        {
            macbookPro.Memory = size;
            return this;
        }

        public override MacbookProBuilder BuildStorage(Storage size)
        {
            macbookPro.Storage = size;
            return this;
        }
    }
}