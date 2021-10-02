﻿using MoonSharp.Interpreter;

namespace Nostalgia.Proxies
{
    public class LuaRuntime : ILuaRuntime
    {
        private readonly Script script = new();

        public Table Globals => script.Globals;

        public virtual void DoString(string code) => script.DoString(code);
    }
}
