#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int n, a, t, p, sum = 0;
	vector<int> v;
	cin >> n;
	for (int i = 0; i < 6; i++)
	{
		cin >> a;
		v.push_back(a);
	}
	cin >> t >> p;

	for (int i : v)
	{
		if (i % t == 0) sum += (i / t);
		else sum += (i / t + 1);
	}
	cout << sum << '\n' << n / p << ' ' << n % p;
	return 0;
}
