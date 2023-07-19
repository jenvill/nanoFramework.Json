namespace System
{
    [AttributeUsage(AttributeTargets.Property), Serializable]
    public class ElementTypeAttribute : Attribute
    {
        private Type _type;

        public ElementTypeAttribute(Type type) => _type = type;

        public Type Type => _type;
    }
}
