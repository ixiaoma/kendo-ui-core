namespace Kendo.Mvc.UI.Fluent
{
    using Kendo.Mvc.Infrastructure;
    using System;
    using System.Collections;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="AutoComplete"/> component.
    /// </summary>
    public class AutoCompleteBuilder : ViewComponentBuilderBase<AutoComplete, AutoCompleteBuilder>, IHideObjectMembers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoCompleteBuilder"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public AutoCompleteBuilder(AutoComplete component)
            : base(component)
        {
        }

        public AutoCompleteBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;
        }

        public AutoCompleteBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {
            Guard.IsNotNull(animationAction, "animationAction");

            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this;
        }
        
        public AutoCompleteBuilder BindTo(IEnumerable data)
        {
            Component.DataSource.Data = data;

            return this;
        }

        public AutoCompleteBuilder ClientEvents(Action<DropDownBaseClientEventsBuilder> clientEventsAction)
        {
            clientEventsAction(new DropDownBaseClientEventsBuilder(Component.ClientEvents));

            return this;
        }

        public AutoCompleteBuilder DataTextField(string field)
        {
            Component.DataTextField = field;

            return this;
        }

        public AutoCompleteBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
        {
            configurator(new ReadOnlyDataSourceBuilder(Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));

            return this;
        }

        public AutoCompleteBuilder Delay(int delay)
        {
            Guard.IsNotNegative(delay, "delay");

            Component.Delay = delay;

            return this;
        }

        /// <summary>
        /// Enables or disables the AutoComplete.
        /// </summary>
        public AutoCompleteBuilder Enable(bool value)
        {
            Component.Enabled = value;

            return this;
        }

        /// <summary>
        /// Use it to enable filtering of items.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().AutoComplete()
        ///             .Name("AutoComplete")
        ///             .Filter("startswith");
        /// %&gt;
        /// </code>
        /// </example>
        public AutoCompleteBuilder Filter(string filter)
        {
            Component.Filter = filter;

            return this;
        }

        /// <summary>
        /// Use it to enable case insensitive bahavior of the AutoComplete. If true the AutoComplete will select the first matching item ignoring its casing.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().AutoComplete()
        ///             .Name("AutoComplete")
        ///             .IgnoreCase(true)
        /// %&gt;
        /// </code>
        /// </example>
        public AutoCompleteBuilder IgnoreCase(bool ignoreCase)
        {
            Guard.IsNotNull(ignoreCase, "ignoreCase");

            Component.IgnoreCase = ignoreCase;

            return this;
        }

        public AutoCompleteBuilder Height(int height)
        {
            Guard.IsNotNegative(height, "height");

            Component.Height = height;

            return this;
        }

        /// <summary>
        /// Use it to enable highlighting of first matched item.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().AutoComplete()
        ///             .Name("AutoComplete")
        ///             .HighlightFirst(true)
        /// %&gt;
        /// </code>
        /// </example>
        public AutoCompleteBuilder HighlightFirst(bool highlightFirst)
        {
            Component.HighlightFirst = highlightFirst;

            return this;
        }

        public AutoCompleteBuilder MinLength(int length)
        {
            Guard.IsNotNegative(length, "length");

            Component.MinLength = length;

            return this;
        }

        public AutoCompleteBuilder Separator(string separator)
        {
            Guard.IsNotNullOrEmpty(separator, "separator");

            Component.Separator = separator;

            return this;
        }

        public AutoCompleteBuilder Suggest(bool suggest)
        {
            Component.Suggest = suggest;

            return this;
        }

        public AutoCompleteBuilder Placeholder(string placeholder)
        {
            Component.Placeholder = placeholder;

            return this;
        }

        public AutoCompleteBuilder Template(string template)
        {
            Guard.IsNotNullOrEmpty(template, "template");

            Component.Template = template;

            return this;
        }

        public AutoCompleteBuilder Value(string value)
        {
            Component.Value = value;

            return this;
        }
    }
}