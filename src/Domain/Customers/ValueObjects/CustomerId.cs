// <copyright file="CustomerId.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Domain.Customers.ValueObjects
{
    using System;

    /// <summary>
    ///     CustomerId
    ///     <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns#entity">
    ///         Entity
    ///         Design Pattern
    ///     </see>
    ///     .
    /// </summary>
    public readonly struct CustomerId : IEquatable<CustomerId>
    {
        private readonly Guid customerId;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CustomerId" /> struct.
        /// </summary>
        /// <param name="customerId">Customer Guid.</param>
        public CustomerId(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new EmptyCustomerIdException(Messages.CustomerIdCannotBeEmpty);
            }

            this.customerId = customerId;
        }

        /// <summary>
        ///     Converts into String.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return this.customerId.ToString();
        }

        /// <summary>
        ///     Converts into Guid.
        /// </summary>
        /// <returns>Guid.</returns>
        public Guid ToGuid() => this.customerId;

        /// <summary>
        ///     Equals.
        /// </summary>
        /// <param name="obj">Other object.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is CustomerId customerIdObj)
            {
                return this.Equals(customerIdObj);
            }

            return false;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.customerId.GetHashCode();
        }

        /// <summary>
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(CustomerId left, CustomerId right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(CustomerId left, CustomerId right)
        {
            return !(left == right);
        }

        /// <summary>
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(CustomerId other)
        {
            return this.customerId == other.customerId;
        }
    }
}
