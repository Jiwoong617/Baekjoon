#include <algorithm>
#include <iostream>
using namespace std;

int main()
{
	int n, m;
	cin >> n >> m;

	long long* arr = new long long[n]();
	long long * remain = new long long[m]();

	long long ans, sum = 0;
	for (int i = 1; i <= n; i++)
	{
		cin >> arr[i-1];
		sum += arr[i-1];
		remain[(sum % m)]++;
	}

	ans = remain[0];
	for (int i = 0; i < m; i++)
		if(remain[i] > 1)
			ans += (remain[i] * (remain[i] - 1)) / 2;

	cout << ans;
	return 0;
}
