#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	int w, h, p, q, t;
	cin >> w >> h >> p >> q >> t;

	cout << w - abs(w - (p + t) % (2 * w)) << ' '
		<< h - abs(h - (q + t) % (2 * h));
	return 0;
}
