#include <vector>
#include <string>
#include <algorithm>
#include <iostream>
using namespace std;
string s;
vector<string> v;
int len = 0;
bool flag;

bool check()
{
	if (len % 2 == 0)
	{
		for (int i = 0; i < len / 4; i++)
			v.push_back("AAAA");
		len %= 4;
		if (len == 2)
			v.push_back("BB");
	}
	else { return false; }

	len = 0;
	return true;
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	cin >> s;
	for (char c : s)
	{
		if (c == 'X') { len++; continue; }
		if (len == 0) { v.push_back("."); continue; }

		flag = check();
		if (!flag) { cout << -1; return 0; }
		v.push_back(".");
	}
	flag = check();
	if (flag)
	{
		for (auto a : v)
			cout << a;
	}
	else cout << -1;
}
