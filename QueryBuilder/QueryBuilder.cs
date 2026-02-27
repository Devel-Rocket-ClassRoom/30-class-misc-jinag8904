using System;
using System.Text;

class QueryBuilder
{
    StringBuilder sb = new();

    private string _strings;

    public QueryBuilder(string strings)
    {
        _strings = strings;
    }

    public QueryBuilder Select(string columns)
    {
        sb.Append(_strings).Append("SELECT ").Append(columns).Append(" ");
        return new QueryBuilder(sb.ToString());
    }

    public QueryBuilder From(string table)
    {
        sb.Append(_strings).Append("FROM ").Append(table).Append(" ");
        return new QueryBuilder(sb.ToString());
    }

    public QueryBuilder Where(string condition)
    {
        sb.Append(_strings).Append("WHERE ").Append(condition).Append(" ");
        return new QueryBuilder(sb.ToString());
    }

    public QueryBuilder OrderBy(string column)
    {
        sb.Append(_strings).Append("ORDER BY ").Append(column).Append(" ");
        return new QueryBuilder(sb.ToString());
    }

    public void Build()
    {
        Console.WriteLine(_strings);
    }
}