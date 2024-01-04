namespace StudemtManagement
{
     class Program
    {
        static void Main(string[] args)
            //Main은 static이기 때문에 최대한 적게 넣어둠 -> 메모리가 고정되어 있기 때문!
        {
            //인스턴스들은 실행 끝나면 GC(Garbage Collector)가 없애줌
            StudentMgr sm = new StudentMgr();
            sm.Run();
        }

    }
}
