namespace NewGenericClass
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        //Fields
        private T[] listElements;
        private int initialCapacity;
        private int maxIndexOfAddedElements;

        //Constructors
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.listElements = new T[this.Capacity];
            this.maxIndexOfAddedElements = 0;
        }

        //Properties
        public int Capacity
        {
            get
            {
                return this.initialCapacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value of Capacity cannot be negative!");
                }
                this.initialCapacity = value;
            }
        }

        public int Count
        {
            get { return this.maxIndexOfAddedElements; }
        }

        //Methods
        public void AddElelment(T element)
        {
            if (this.maxIndexOfAddedElements >= this.Capacity)
            {
                this.DoubleSize();
            }
            this.listElements[this.maxIndexOfAddedElements] = element;
            this.maxIndexOfAddedElements++;
        }

        public T ElementAtIndex(int index)
        {
            if (index >= this.maxIndexOfAddedElements || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Index is out of Elements range! Must be between (0;{0})! Your index: {1}!", (maxIndexOfAddedElements - 1), index));
            }
            else
            {
                return this.listElements[index];
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index >= this.maxIndexOfAddedElements || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Index is out of Elements range! Must be between (0;{0})! Your index: {1}!", (maxIndexOfAddedElements - 1), index));
            }
            else
            {
                for (int i = index; i < this.maxIndexOfAddedElements - 1; i++)
                {
                    this.listElements[i] = this.listElements[i + 1];
                }
                this.listElements[maxIndexOfAddedElements - 1] = default(T);
                this.maxIndexOfAddedElements--;
            }
        }

        public void AddAtIndex(int index, T element)
        {
            if (index >= this.maxIndexOfAddedElements || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Index is out of Elements range! Must be between (0;{0})! Your index: {1}!", (maxIndexOfAddedElements - 1), index));
            }
            else
            {
                for (int i = this.maxIndexOfAddedElements - 1; i >= index; i--)
                {
                    if (this.maxIndexOfAddedElements >= this.Capacity)
                    {
                        this.DoubleSize();
                    }
                    this.listElements[i + 1] = this.listElements[i];
                }
                this.listElements[index] = element;
                this.maxIndexOfAddedElements++;
            }
        }

        public void ClearList()
        {
            for (int i = 0; i < this.maxIndexOfAddedElements; i++)
            {
                this.listElements[i] = default(T);
            }
            this.maxIndexOfAddedElements = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.maxIndexOfAddedElements; i++)
            {
                if (this.listElements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder genericBuilder = new StringBuilder();

            for (int i = 0; i < this.maxIndexOfAddedElements - 1; i++)
            {
                genericBuilder.AppendFormat("{0},", listElements[i]);
            }
            genericBuilder.Append(listElements[this.maxIndexOfAddedElements - 1]);

            return genericBuilder.ToString();
        }

        private void DoubleSize()
        {
            T[] oldListElements = this.listElements;
            this.Capacity = Capacity * 2;
            this.listElements = new T[this.Capacity];
            for (int i = 0; i < this.maxIndexOfAddedElements; i++)
            {
                this.listElements[i] = oldListElements[i];
            }
        }

        public T MinElement()
        {
            if (this.maxIndexOfAddedElements == 0)
            {
                throw new IndexOutOfRangeException("GenericList is Empty!");
            }
            T minElement = this.listElements[0];

            for (int i = 1; i < this.maxIndexOfAddedElements; i++)
            {
                if (minElement.CompareTo(listElements[i])>0)
                {
                    minElement = listElements[i];
                }
            }
            return minElement;
        }

        public T MaxElement()
        {
            if (this.maxIndexOfAddedElements == 0)
            {
                throw new IndexOutOfRangeException("GenericList is Empty!");
            }
            T maxElement = this.listElements[0];

            for (int i = 1; i < this.maxIndexOfAddedElements; i++)
            {
                if (maxElement.CompareTo(listElements[i]) < 0)
                {
                    maxElement = listElements[i];
                }
            }
            return maxElement;
        }
    }
}
