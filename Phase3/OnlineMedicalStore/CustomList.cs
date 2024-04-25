using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
        private int _count;
        private int _capacity;
        private Type[] _array;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        public Type this[int index] { get{return _array[index];} set{_array[index]=value;} }
        //constructor
        public CustomList(){
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        //add
        public void Add(Type element){
            if(_count==_capacity){
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }
        public void GrowSize(){
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++){
                temp[i]=_array[i];
            }
            _array=temp;
        }
        //add range
        public void AddRange(CustomList<Type> elements){
            _capacity=_capacity+elements.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++){
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=_count;i<_count+elements.Count;i++){
                temp[i]=elements[j];
                j++;
            }
            _array=temp;
            _count=_count+elements.Count;
        }

        //custom for each
        int position;
        public IEnumerator GetEnumerator(){
            position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext(){
            if(position<_count-1){
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset(){
            position=-1;
        }
        public object Current{get{return _array[position];}}
        
    }
}