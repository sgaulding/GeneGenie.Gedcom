// <copyright file="GedcomChangeDate.cs" company="GeneGenie.com">
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see http:www.gnu.org/licenses/ .
//
// </copyright>
// <author> Copyright (C) 2008 David A Knight david@ritter.demon.co.uk </author>
// <author> Copyright (C) 2016 Ryan O'Neill r@genegenie.com </author>

namespace GeneGenie.Gedcom
{
    /// <summary>
    /// The date on which a GEDCOM record was changed.
    /// </summary>
    public class GedcomChangeDate : GedcomDate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GedcomChangeDate"/> class.
        /// </summary>
        /// <param name="database">The GEDCOM database to associate this date with.</param>
        public GedcomChangeDate(GedcomDatabase database)
            : base(database)
        {
        }

        /// <inheritdoc/>
        protected override void Changed()
        {
        }
    }
}
