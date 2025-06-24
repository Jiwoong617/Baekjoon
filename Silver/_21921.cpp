#include <iostream>

using namespace std;

int main()
{
	int n, x, a; cin >> n >> x;
	int* arr = new int[n + 1]();
	for (int i = 0; i < n; i++)
	{
		cin >> a;
		arr[i + 1] = arr[i] + a;
	}

	int cnt = 1, ans = arr[x];
	for (int i = 1; i <= n - x; i++)
	{
		int t = arr[i + x] - arr[i];
		if (t == ans)
			cnt++;
		else if (t > ans)
		{
			cnt = 1;
			ans = t;
		}
	}

	if (ans)
		cout << ans << '\n' << cnt;
	else
		cout << "SAD";

	return 0;
}
