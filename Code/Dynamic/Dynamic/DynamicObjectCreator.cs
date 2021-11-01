using System;
using System.Reflection;
using System.Dynamic;
using System.Collections.Generic;

namespace Dynamic {

    public class DynamicObjectCreator : DynamicObject {
        Assembly execng_code = Assembly.GetExecutingAssembly();

        public override bool TryGetMember(GetMemberBinder binder, out object result) {
            Type[] class_types = execng_code.GetTypes();
            
            foreach (var type in class_types) {
                if (type.Name == binder.Name) {
                    Type [] newType = { };
                    result = Activator.CreateInstance(type);
                    return true;
                }
            }

            result = null;
            return false;
        }
    }
}