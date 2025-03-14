#include <iostream>
#include <vector>
#include <string>

using namespace std;

int main()
{
	int n, a = 0, b = 0;
	string s;
	vector<string> v;
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cin >> s;
		v.push_back(s);
	}

	for (int i = 0; i < n; i++)
	{
		int aa = 0, bb = 0;
		for (int j = 0; j < n; j++)
		{
			if (v[i][j] == '.') aa++;
			else { a = (aa > 1 ? a + 1 : a); aa = 0; }
			if (v[j][i] == '.') bb++;
			else { b = (bb > 1 ? b + 1 : b); bb = 0; }
		}

		if (aa > 1) a++;
		if (bb > 1) b++;
	}


	cout << a << ' ' << b;
	return 0;
}
