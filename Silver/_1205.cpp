#include <iostream>

using namespace std;

int main()
{
	int n, t, p, rank = 1, i;
	cin >> n >> t >> p;
	int* num = new int[n]();
	for (int i = 0; i < n; i++)
		cin >> num[i];

	for (i = 0; i < n; i++)
	{
		if (t < num[i]) rank++;
		else if (t > num[i]) break;
	}

	cout << (i == p ? -1 : rank);
	return 0;
}
