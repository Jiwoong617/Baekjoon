#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int n, t; cin >> n;
	vector<int> a, a_sort;
	for (int i = 0; i < n; i++)
	{
		cin >> t;
		a.push_back(t);
		a_sort.push_back(t);
	}

	sort(a_sort.begin(), a_sort.end());
	for (int i : a)
	{
		auto it = find(a_sort.begin(), a_sort.end(), i);
		*it = -1;
		cout << it - a_sort.begin() << ' ';
	}

	return 0;
}
