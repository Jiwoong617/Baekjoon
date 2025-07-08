#include <iostream>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	int n, a, m, i, j; cin >> n;
	int* num = new int[n + 1]();
	for (int i = 1; i <= n; i++)
	{
		cin >> a;
		num[i] = a + num[i - 1];
	}

	cin >> m;
	while (m--)
	{
		cin >> i >> j;
		cout << num[j] - num[i - 1] << '\n';
	}

	return 0;
}
