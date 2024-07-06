using System;
    /// <summary>
    /// class obj
    /// </summary>


    class Obj
    {
        
        public static bool IsOfTypeInt(object obj)
        {
            int n1 = 1;
            return Object.ReferenceEquals(obj.GetType(), n1.GetType());
        }
    }
