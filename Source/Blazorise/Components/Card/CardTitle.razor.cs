﻿#region Using directives
using Blazorise.Utilities;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise;

/// <summary>
/// Card titles are used by adding title to a heading tag.
/// </summary>
public partial class CardTitle : BaseTypographyComponent
{
    #region Members

    private int? size;

    #endregion

    #region Methods

    /// <inheritdoc/>
    protected override void BuildClasses( ClassBuilder builder )
    {
        builder.Append( ClassProvider.CardTitle( InsideHeader ) );
        builder.Append( ClassProvider.CardTitleSize( InsideHeader, Size ) );

        base.BuildClasses( builder );
    }

    #endregion

    #region Properties

    /// <summary>
    /// Indicates if the title is placed inside if card header.
    /// </summary>
    protected bool InsideHeader => ParentCardHeader != null;

    /// <summary>
    /// Number from 1 to 6 that defines the title size where the smaller number means larger text.
    /// </summary>
    /// <remarks>
    /// TODO: change to enum
    /// </remarks>
    [Parameter]
    public int? Size
    {
        get => size;
        set
        {
            size = value;

            DirtyClasses();
        }
    }

    /// <summary>
    /// Gets or sets the reference to the parent <see cref="CardHeader"/> component.
    /// </summary>
    [CascadingParameter] public CardHeader ParentCardHeader { get; set; }

    #endregion
}