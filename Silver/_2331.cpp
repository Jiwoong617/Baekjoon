#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int num[300000];

int main()
{
	int a, p, n; cin >> a >> p;

	num[a]++;
	while (1)
	{
		n = 0;
		while (a > 0)
		{
			n += pow(a % 10, p);
			a /= 10;
		}
		num[n]++;
		a = n;

		if (num[n] > 2)
			break;
	}

	cout << count(num, num + 300000, 1);
	return 0;
}
