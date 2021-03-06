﻿/**
 * Outlook integration for SuiteCRM.
 * @package Outlook integration for SuiteCRM
 * @copyright SalesAgility Ltd http://www.salesagility.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU LESSER GENERAL PUBLIC LICENCE as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU LESSER GENERAL PUBLIC LICENCE
 * along with this program; if not, see http://www.gnu.org/licenses
 * or write to the Free Software Foundation,Inc., 51 Franklin Street,
 * Fifth Floor, Boston, MA 02110-1301  USA
 *
 * @author SalesAgility <info@salesagility.com>
 */
namespace SuiteCRMAddIn.Tests
{
    using System.Collections.Generic;
    using SuiteCRMClient.Logging;

    /// <summary>
    /// An abstract superclass for test classes which need a logger.
    /// </summary>
    public abstract class WithLoggerTests
    {
        /// <summary>
        /// Many of the things we test need access to a logger.
        /// </summary>
        protected readonly ILogger Log;

        /// <summary>
        /// Construct a new instance of WithLoggerTests.
        /// </summary>
        public WithLoggerTests()
        {
            this.Log = Log4NetLogger.FromFilePath("add-in-tests", "c:\\temp\\suitecrmoutlook-test.log", () => GetLogHeader(), LogEntryType.Debug);
        }

        private IEnumerable<string> GetLogHeader()
        {
            yield return "Froboz";
        }
    }
}