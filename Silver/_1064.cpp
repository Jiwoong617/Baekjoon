#include <iostream>
#include <cmath>

using namespace std;

double len(double x1, double y1, double x2, double y2)
{
	return sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
}

int main()
{
	cout.precision(16);
	cout << fixed;

	double ax, ay, bx, by, cx, cy, ab, ac, bc;
	cin >> ax >> ay >> bx >> by >> cx >> cy;

	if ((bx - ax) * (cy - ay) - (cx - ax) * (by - ay) == 0)
	{
		cout << -1;
		return 0;
	}

	ab = len(ax, ay, bx, by);
	ac = len(ax, ay, cx, cy);
	bc = len(bx, by, cx, cy);

	cout << max(2 * (ab + ac), max(2 * (ab + bc), 2 * (ac + bc)))
		- min(2 * (ab + ac), min(2 * (ab + bc), 2 * (ac + bc)));

	return 0;
}
