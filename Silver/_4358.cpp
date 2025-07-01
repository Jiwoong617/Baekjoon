#include <iostream>
#include <map>
#include <string>

using namespace std;

int main()
{
	cout << fixed;
	cout.precision(4);

	map<string, int> m;
	string s;
	int cnt = 0;
	while (getline(cin, s))
	{
		cnt++;
		m[s]++;
	}

	for (auto a : m)
		cout << a.first << ' ' << (double)a.second / cnt * 100 << '\n';

	return 0;
}
