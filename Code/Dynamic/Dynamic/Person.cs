using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Dynamic
{   
    public class Person : DynamicObject {

        private Dictionary<string, object> fields = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result) {
            string member_name = binder.Name;
            if(fields.ContainsKey(member_name)) {
                result = fields[member_name];
                return true;
            }
            result = null;
            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value) {
            var member_name = binder.Name;

            if (fields.ContainsKey(member_name))
                fields[member_name] = value;
            else
                fields.Add(member_name, value);
            return true;
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result) {
            try {
                var Name = indexes[0].ToString();
                if (fields.ContainsKey(Name)) {
                    result = fields[Name];
                    return true;
                }
                result = null;
                return false;
            }
            catch (Exception) { throw new Exception("Solo se indexa en una dimension"); }
        }
        
        public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value) {
            try {
                var Name = indexes[0].ToString();
                if (fields.ContainsKey(Name))
                    fields[Name] = value;
                else
                    fields.Add(Name, value);
                return true;
            }
            catch (Exception) { throw new Exception("Solo se indexa en una dimension"); }
        }

        public override bool TryInvoke(InvokeBinder binder, object[] args, out object result) {
            for (int i = 0; i < args.Length; i++)
                fields.Add(binder.CallInfo.ArgumentNames[i], args[i]);
            
            result = this;
            return true;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result) {
            var Name = binder.Name;
            if (fields.ContainsKey(Name))
            {
                if (args.Length > 1)
                    fields[Name] = args;
                else
                    fields[Name] = args[0];
                result = this;
                return true;
            }
            if (args.Length > 1)
                fields.Add(Name, args);
            else
                fields.Add(Name, args[0]);
            result = this;
            return true;
        }

        public override string ToString() {
            return "Nombre: " + fields["FirstName"] + " | Apellido: " + fields["LastName"];
        }
    }
}