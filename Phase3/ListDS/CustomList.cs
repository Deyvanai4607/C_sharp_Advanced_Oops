using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDS
{
    public partial class CustomList<Type>
    {
        //feilds
        private int _count;
        private int _capacity;
        //properties
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        private Type [] _array;
        public Type this[int index]{   //this refer to the object
            get{return _array[index];}
            set{_array[index]=value;}
        }
        //Constructor
        public CustomList(){
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
         public CustomList(int size){
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        //Add method
        public void Add(Type element){
            if(_count==_capacity){
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }
        void GrowSize(){
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++){
                temp[i]=_array[i];
            }
            _array=temp;
        }
        //AddRange method
        public void AddRange(CustomList<Type> elements){
            _capacity=_capacity+elements.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++){
                temp[i]=_array[i];
            }
            int k=0;
            for(int i=_count;i<elements.Count+_count;i++){
                temp[i]=elements[k];//k is the index value 
                k++;
            }
            _array=temp;
            _count=_count+elements.Count;
        }
        //Contains method
        public bool Contains(Type element){
            bool temp=false;
            foreach(Type data in _array){
                if(data.Equals(element)){
                    temp=true;
                    break;
                }
            }
            return temp;
        }
        //IndexOff method
        public int IndexOff(Type element){
            int index=-1;
            for(int i=0;i<_count;i++){
                if(element.Equals(_array[i])){
                    index=i;
                    break;
                }
            }
            return index;
        }
        //Insert method
        public void Insert(int position,Type element){
            _capacity=_capacity+1+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count+1;i++){
                if(i<position){
                    temp[i]=_array[i];
                }else if(i==position){
                    temp[i]=element;
                }else{
                    temp[i]=_array[i-1];
                }
            }
            _count++;
            _array=temp;
        }
        //RemoveAt method
        public void RemoveAt(int position){
            for(int i=0;i<_count;i++){
                if(i>=position){
                    _array[i]=_array[i+1];
                }
            }
            _count--;
        }
        //Remove method
        public void Remove(Type element){
            int position=IndexOff(element);
            if(position>=0){
                RemoveAt(position);
            }
        }
        //Reverse
        public void Reverse(){
            Type[] temp=new Type[_capacity];
            int j=0;
            for(int i=_count-1;i>=0;i--){
                temp[j]=_array[i];
                j++;
            }
            _array=temp;
        }
        //Insert Range method
        public void InsertRange(int position,CustomList<Type> element){
            _capacity=_count+element.Count+4;
            Type[] temp =new Type[_capacity];
            for(int i=0;i<position;i++){
                temp[i]=_array[i];
            } 
            int j=0;  
            for(int i=position;i<position+element.Count;i++){
                temp[i]=element[j];
                j++;
            }  
            int k=position;    
            for(int i=position+element.Count;i<_count+element.Count;i++){
                temp[i]=_array[k];
                k++;
            }  
            _count=_count+element.Count;  
            _array=temp;
             
        }
        //Sort method
        public void Sort(){
            for(int i=0;i<_count-1;i++){
                for(int j=0;j<_count-1;j++){
                    if(IsGreater(_array[j],_array[j+1])){
                        Type temp=_array[j+1];
                        _array[j+1]=_array[j];
                        _array[j]=temp;
                    }
                }
            }
        }
        public bool IsGreater(Type value1,Type value2){
            int result=Comparer<Type>.Default.Compare(value1,value2);
            // value1 => equal=0,greater =1,lesser = -1
            if(result>0){
                return true;
            }
            return false;
        }

    }
}