#include <iostream>
#include <cmath>

using namespace std;

int n;
int sosu[4] = { 2, 3, 5, 7 };
int lastSosu[4] = { 1, 3, 7, 9 };

bool checkSosu(int num)
{
	for (int i = 2; i < sqrt(num); i++)
	{
		if (num % i == 0)
			return false;
	}
	return true;
}

void dfs(int num, int count)
{
	if (count == n)
	{
		cout << num << endl;
		return;
	}

	for (int i = 0; i < 4; i++)
	{
		int t = num * 10 + lastSosu[i];
		if (checkSosu(t))
			dfs(t, count+1);
	}
}

int main()
{
	cin >> n;
	for (int i = 0; i < 4; i++)
		dfs(sosu[i], 1);

	return 0;
}
