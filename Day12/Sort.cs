using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
    class Sort
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void cwarr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                        Swap(ref arr[j - 1], ref arr[j]);
                }
            }
            return arr;
        }
        public static int[] SelectSort(int[] arr)
        {
            int minindex;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minindex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minindex] > arr[j])
                    {
                        minindex = j;
                    }
                }

                if (minindex != i)
                {
                    Swap(ref arr[minindex], ref arr[i]);
                }
            }
            return arr;
        }
        public static int[] InsertSort(int[] arr)
        {
            int current;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                current = arr[i + 1];
                int preIndex = i;
                while (i >= 0 && current < arr[i])
                {
                    arr[i + 1] = arr[i];
                    preIndex--;
                }
                arr[i + 1] = current;
            }
            return arr;
        }
        public static int[] ShellSort(int[] arr)
        {
            int temp;
            int gap = arr.Length / 2;
            while (gap > 0)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    temp = arr[i];
                    int preIndex = i - gap;
                    while (preIndex >= 0 && arr[preIndex] > temp)
                    {
                        arr[preIndex + gap] = arr[preIndex];
                        preIndex -= gap;
                    }
                    arr[preIndex + gap] = temp;
                }
                gap /= 2;
            }
            return arr;
        }
        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }

        private static void MergeSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(array, p, q);
                MergeSort(array, q + 1, r);
                Merge(array, p, q, r);
            }
        }

        private static void Merge(int[] array, int p, int q, int r)
        {
            int[] L = new int[q - p + 2];
            int[] R = new int[r - q + 1];
            L[q - p + 1] = int.MaxValue;
            R[r - q] = int.MaxValue;

            for (int i = 0; i < q - p + 1; i++)
            {
                L[i] = array[p + i];
            }

            for (int i = 0; i < r - q; i++)
            {
                R[i] = array[q + 1 + i];
            }

            int j = 0;
            int k = 0;
            for (int i = 0; i < r - p + 1; i++)
            {
                if (L[j] <= R[k])
                {
                    array[p + i] = L[j];
                    j++;
                }
                else
                {
                    array[p + i] = R[k];
                    k++;
                }
            }
        }

        /// <summary>
        /// 快速排序_主函数
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="count">数组元素个数</param>
        public static void QuickSort(int[] arr)
        {
            QSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// 快速排序_递归调用
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="low">低位索引</param>
        /// <param name="high">高位索引</param>
        private static void QSort(int[] arr, int low, int high)
        {
            int pivot;

            while (low < high)
            {
                pivot = Partition(arr, low, high);
                QSort(arr, low, pivot - 1);
                //尾递归，可以减少一次递归堆栈深度
                low = pivot + 1;
            }
        }

        /// <summary>
        /// 获取枢轴数
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="low">低位索引</param>
        /// <param name="high">高位索引</param>
        /// <returns></returns>
        private static int Partition(int[] arr, int low, int high)
        {
            int pivotkey;
            int m = low + (high - low) / 2;
            //下面是三数取中优化
            //交换左端与右端数据，保证左端较小
            if (arr[low] > arr[high])
            {
                Swap(ref arr[low], ref arr[high]);
            }
            //交换中间与右端数据，保证中间较小
            if (arr[m] > arr[high])
            {
                Swap(ref arr[m], ref arr[high]);
            }
            //交换中间与左端数据，保证左端较小
            if (arr[m] > arr[low])
            {
                Swap(ref arr[low], ref arr[m]);
            }
            //默认选取当前数组的第一个值作为枢轴值
            pivotkey = arr[low];
            //枢轴备份
            int pivotkeyback = pivotkey;
            while (low < high)
            {
                while (low < high && arr[high] >= pivotkey)
                {
                    high--;
                }
                arr[low] = arr[high];
                while (low < high && arr[low] <= pivotkey)
                {
                    low++;
                }
                arr[high] = arr[low];
            }
            //将枢轴数值替换回array[low]
            arr[low] = pivotkeyback;
            //返回当前枢轴下标
            return low;
        }

        //堆排序算法（传递待排数组名，即：数组的地址。故形参数组的各种操作反应到实参数组上）
        private static void HeapSort(int[] array)
        {

            BuildMaxHeap(array);    //创建大顶推（初始状态看做：整体无序）
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(ref array[0], ref array[i]); //将堆顶元素依次与无序区的最后一位交换（使堆顶元素进入有序区）
                MaxHeapify(array, 0, i); //重新将无序区调整为大顶堆
            }

        }

        ///<summary>
        /// 创建大顶推（根节点大于左右子节点）
        ///</summary>
        ///<param name="array">待排数组</param>
        private static void BuildMaxHeap(int[] array)
        {

            //根据大顶堆的性质可知：数组的前半段的元素为根节点，其余元素都为叶节点
            for (int i = array.Length / 2 - 1; i >= 0; i--) //从最底层的最后一个根节点开始进行大顶推的调整
            {
                MaxHeapify(array, i, array.Length); //调整大顶堆
            }

        }

        ///<summary>
        /// 大顶推的调整过程
        ///</summary>
        ///<param name="array">待调整的数组</param>
        ///<param name="currentIndex">待调整元素在数组中的位置（即：根节点）</param>
        ///<param name="heapSize">堆中所有元素的个数</param>
        private static void MaxHeapify(int[] array, int currentIndex, int heapSize)
        {

            int left = 2 * currentIndex + 1;    //左子节点在数组中的位置
            int right = 2 * currentIndex + 2;   //右子节点在数组中的位置
            int large = currentIndex;   //记录此根节点、左子节点、右子节点 三者中最大值的位置

            if (left < heapSize && array[left] > array[large])  //与左子节点进行比较
            {
                large = left;
            }
            if (right < heapSize && array[right] > array[large])    //与右子节点进行比较
            {
                large = right;
            }
            if (currentIndex != large)  //如果 currentIndex != large 则表明 large 发生变化（即：左右子节点中有大于根节点的情况）
            {
                Swap(ref array[currentIndex], ref array[large]);    //将左右节点中的大者与根节点进行交换（即：实现局部大顶堆）
                MaxHeapify(array, large, heapSize); //以上次调整动作的large位置（为此次调整的根节点位置），进行递归调整
            }


        }


        /// <summary>
        /// 求最值，初新组，正反填充数组得
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] CountingSort(int[] array)
        {
            //求最大最小值
            int min = array[0], max = array[0];
            foreach (var item in array)
            {
                max = item > max ? item : max;
                min = item < min ? item : min;
            }
            //初始化新组并赋值
            var bucket = new int[max - min + 1];//数组长度比实际个数大一
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = 0;
            }
            //正填充
            int bias = 0 - min;
            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] + bias]++;
            }
            //反填充
            int arrayIndex = 0, bucketIndex = 0;
            while (arrayIndex < array.Length)
            {
                if (bucket[bucketIndex] != 0)
                {
                    array[arrayIndex] = bucketIndex - bias;
                    bucket[bucketIndex]--;
                    arrayIndex++;
                }
                else
                {
                    bucketIndex++;
                }
            }
            return array;
        }




        public static  void BucketSort(int[] arr, int size)
        {
            //找出数组中的最大最小值
            int max = 0;
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            //创建桶，每个桶可以存放size种数
            int bucketCount = (max - min) / size + 1;
            List<List<int>> buckets = new List<List<int>>();
            for (int i = 0; i < bucketCount; i++)
            {
                buckets.Add(new List<int>());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int bucketNum = (arr[i] - min) / size;
                buckets[bucketNum].Add(arr[i]);
            }
            int count = 0;//数组下标
            for (int i = 0; i < bucketCount; i++)
            {
                //对每个桶内的数重新排序，可以用其他排序方法
                List<int> bucket = buckets[i];
                bucket.Sort();
                foreach (int temp in bucket)
                {
                    arr[count] = temp;
                    count++;
                }

            }

        }


        public static  void RadixSort(int[] arr)
        {
            //找出最大值
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            //求最大值有几位数
            int num = 0;
            while (max > 0)
            {
                max /= 10;
                num++;
            }

            //创建桶
            List<List<int>> buckets = new List<List<int>>();
            for (int i = 0; i < 10; i++)
            {
                buckets.Add(new List<int>());
            }

            for (int i = 0; i < num; i++)
            {
                //将数组中的元素分配到桶中
                for (int j = 0; j < arr.Length; j++)
                {
                    //取出345中的十位，先除100取余数，再除10取整数
                    int remainder = (int)(arr[j] % Math.Pow(10, i + 1) / Math.Pow(10, i));
                    buckets[remainder].Add(arr[j]);//添加进对应序号（0~9）的桶中
                }

                //再将桶中的数据取出放回到数组中
                int count = 0;//数组下标
                for (int j = 0; j < 10; j++)//桶的标号
                {
                    List<int> curBucket = buckets[j];
                    while (curBucket.Count > 0)
                    {
                        arr[count] = curBucket[0];//取第一个
                        curBucket.RemoveAt(0);//移除第一个
                        count++;//数组下标增加
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[5] { 14, 19, 17, 16, 18 };
            cwarr(arr);



            //BubbleSort(arr);
            //SelectSort(arr);
            //SelectSort(arr);
            //ShellSort(arr);
            //MergeSort(arr);
            //QuickSort(arr);
            //HeapSort(arr);
            //CountSort(arr);
            //CountingSort(arr);
            //BucketSort(arr, 2);
            //RadixSort(arr);
            cwarr(arr);
            Console.ReadLine();
        }
    }
}
