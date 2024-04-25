using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public partial class CustomList<Type>
    {
        //feilds
        private  int _count;  
        private  int _capacity;     
        private  Type[] _array;
        //properties
        public  int Count { get{return _count;}   }
        public  int Capacity { get{return _capacity;}   }
        public Type this[int index]{
            get{return _array[index];}
            set{_array[index]=value;}
        }
        //constructor
        public  CustomList(){
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
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
    }
}