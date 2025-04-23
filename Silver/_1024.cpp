#include <iostream>

using namespace std;

int main()
{
	int n, l, i;
	cin >> n >> l;

	bool can = false;
	double a, b;
	for (i = l; i <= 100; i++)
	{
		b = i * (i - 1) / 2;
		a = (n - b) / i;

		if (a == (int)a && a > -1)
		{
			can = true;
			break;
		}
	}

	if (can)
	{
		for (int j = 0; j < i; j++)
			cout << (int)a + j << ' ';
	}
	else cout << -1;

	return 0;
}
