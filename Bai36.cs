using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách listf các số thực 4 byte
        List<float> listf = new List<float>();

        // Bổ sung vào cuối list lần lượt các số 3.5,-1.2, 7.8,-5
        listf.Add(3.5f);
        listf.Add(-1.2f);
        listf.Add(7.8f);
        listf.Add(-5f);

        // Duyệt danh sách theo chỉ số (không sử dụng foreach) để hiển thị các phần tử
        Console.WriteLine("Danh sách các số thực:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        listf.Sort();

        Console.WriteLine("\nDanh sách các số thực sau khi sắp xếp:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }
    }
}