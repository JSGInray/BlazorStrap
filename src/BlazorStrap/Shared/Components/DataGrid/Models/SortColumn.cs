﻿using BlazorStrap.Shared.Components.DataGrid.Columns;

namespace BlazorStrap;

public record SortColumn<TGridItem>(Guid Id, bool Descending, int Order, bool Sorted, string PropertyPath, ColumnBase<TGridItem> Column)
{
    public bool Descending { get; set; }
    public int Order { get; set; }
    public bool Sorted { get; set; }
}