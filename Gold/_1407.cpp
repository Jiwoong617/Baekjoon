#include <iostream>
#define ll long long

using namespace std;

ll f(ll n)
{
	ll num = 0, div = 1;
	
	while (n)
	{
		if (n % 2) num += (n / 2 + 1) * div;
		else num += n / 2 * div;

		div *= 2;
		n /= 2;
	}

	return num;
}

int main()
{
	ll a, b; cin >> a >> b;
	cout << f(b) - f(a - 1);
	return 0;
}
