#include <algorithm>
#include <vector>
#include <string>
#include <iostream>
using namespace std;

int n;
char c[9];
bool check[10] = { false };
vector<string> v;

bool Check(char a, char b, char boodoongho)
{
	if (boodoongho == '<') return a < b;
	else return a > b;
}

void BackT(int count, string s)
{
	if (count > n)
	{
		v.push_back(s);
		return;
	}

	for (int i = 0; i < 10; i++)
	{
		if (check[i])
			continue;
		if(count == 0 || Check(s[count-1], i+'0', c[count-1]))
		{
			check[i] = true;
			BackT(count + 1, s + to_string(i));
			check[i] = false;
		}
	}
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	cin >> n;
	for (int i = 0; i < n; i++)
		cin >> c[i];

	BackT(0, "");
	sort(v.begin(), v.end());
	cout << v.back() << '\n' << v.front();
}
