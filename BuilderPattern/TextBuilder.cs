﻿using System.Text;

namespace BuilderPattern
{
    public class TextBuilder : Builder
    {
        private readonly StringBuilder _buffer = new StringBuilder();

        public override void MakeTitle(string title)
        {
            _buffer.Append("==============================\n");
            _buffer.Append($"『{title}』\n");
            _buffer.Append("\n");
        }

        public override void MakeString(string str)
        {
            _buffer.Append($" █ {str}\n");
            _buffer.Append("\n");
        }

        public override void MakeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                _buffer.Append($"     {items[i]}\n");
            }

            _buffer.Append("\n");
        }

        public override void Close()
        {
            _buffer.Append("==============================\n");
        }

        public string GetResult()
        {
            return _buffer.ToString();
        }
    }
}
