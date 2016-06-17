namespace VersionAttribute
{
    using System;    

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        //Fields
        private int majorVersion;
        private int minorVersion;

        //Constructors
        public VersionAttribute(AttributeType typeOfAttribute, string author, int majorVersion, int minorVersion)
        {
            this.ComponentType = typeOfAttribute;
            this.Name = author;
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }        

        //Properties
        public AttributeType ComponentType { get; private set; }

        public string Name { get; private set; }

        private int MajorVersion
        {
            get { return this.majorVersion; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive");
                }
                else
                {
                    this.majorVersion = value;
                }
            }
        }

        private int MinorVersion
        {
            get { return this.minorVersion; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive");
                }
                else
                {
                    this.minorVersion = value;
                }
            }
        }

        public string Version
        {
            get
            {
                return string.Format("{0:D2}.{1:D2}", this.MajorVersion, this.MinorVersion);
            }
        }
    }
}
