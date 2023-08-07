'Bài tập 1.3
'   1. Viết chương trình nhập vào các thông tin: Tên, Tuổi, Địa chỉ, Lớp
'   2. Xuất ra màn hình theo định dạng: Bạn tên <Tên>, <Tuổi> tuổi, ở <Địa chỉ>, học <Lớp> dưới dạng
'       a. Giao diện Console
'       b. Hộp thông báo Msgbox
'   3. Lưu project vào thư mục có tên là BaiTap13.
Imports System

Module Program
    Sub WriteCon(ByVal txt As String)
        Console.WriteLine(txt)
    End Sub
    Sub Main(args As String())
        Dim name, address, className As String
        Dim Age As Integer
        Console.OutputEncoding = Text.Encoding.UTF8
        Console.WriteLine("---Chương trình khởi điểm----")
        WriteCon("Nhập tên: ")
        name = Console.ReadLine()
        WriteCon("Nhập tuổi: ")
        Age = Console.ReadLine()
        WriteCon("Nhập địa chỉ: ")
        address = Console.ReadLine()
        WriteCon("Nhập tên lớp: ")
        className = Console.ReadLine()
        WriteCon("-------------DATA OUTPUT---------------")
        Console.WriteLine("Họ và Tên: " + name)
        Console.WriteLine("Tuổi: " + Age.ToString())
        Console.WriteLine("Địa chỉ: " + address)
        Console.WriteLine("Tên Lớp: " + className)
        WriteCon("--------------------------------------")

        Console.ReadLine()


    End Sub

End Module


