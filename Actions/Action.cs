using System;
using System.Collections.Generic;
using cse210_RH2_csharp.Casting;

namespace cse210_RH2_csharp
{
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public abstract class Action
    {
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}