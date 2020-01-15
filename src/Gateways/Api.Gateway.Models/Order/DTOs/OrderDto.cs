﻿using System;
using System.Collections.Generic;

namespace Api.Gateway.Models.Order.DTOs
{
    public enum OrderStatus
    {
        Cancel,
        Pending,
        Approved
    }

    public enum OrderPayment
    {
        CreditCard,
        PayPal,
        BankTransfer
    }

    public class OrderDto
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public OrderPayment PaymentType { get; set; }
        public int CustomerId { get; set; }
        public IEnumerable<OrderDetailDto> Items { get; set; } = new List<OrderDetailDto>();
        public DateTime CreatedAt { get; set; }
        public decimal Total { get; set; }
    }

    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}
