List<int> Foo(int a, int b){
    int ceiling = a > b ? a : b;
    int divisor = a < b ? a : b;
    var ans = new List<int>(); 
    for (int i = divisor; i <= ceiling; i += divisor){
        if (i % 2 == 0){
            ans.Add(i);
        }
    }
    return ans;
}