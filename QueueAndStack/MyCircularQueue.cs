namespace LeetCodeExercise.QueueAndStack
{
    //这个需要重新实现
    //目前这个写法速度太慢了
    
    //循环队列
    public class MyCircularQueue
    {
        public MyCircularQueue(int k)
        {
            _datas = new int[k];
            for (int i = 0; i < _datas.Length; i++)
            {
                _datas[i] = -1;
            }

            _head = -1;
            _tail = -1;
            _count = 0;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            _count++;
            if (_count > _datas.Length)
            {
                _count = _datas.Length;
                return false;
            }

            if (_count == 1)
            {
                _tail = 0;
                _head = 0;
            }
            else
            {
                _tail++;
                _tail = _tail % _datas.Length;
            }

            _datas[_tail] = value;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            _count--;
            if (_count < 0)
            {
                _count = 0;
                return false;
            }

            _datas[_head] = -1;
            if (_count == 0)
            {
                _head = -1;
                _tail = -1;
            }
            else
            {
                _head++;
                _head = _head % _datas.Length;
            }

            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (_head < 0 || _head >= _datas.Length)
            {
                return -1;
            }

            return _datas[_head];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (_tail < 0 || _tail >= _datas.Length)
            {
                return -1;
            }

            return _datas[_tail];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return _count <= 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return _count >= _datas.Length;
        }

        private int[] _datas;
        private int _head;
        private int _tail;
        private int _count;
    }
}