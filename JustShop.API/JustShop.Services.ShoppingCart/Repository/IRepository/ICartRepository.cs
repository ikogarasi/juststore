﻿using Restaurant.Services.ShoppingCartAPI.Models.Dto;

namespace Restaurant.Services.ShoppingCartAPI.Repository.IRepository
{
    public interface ICartRepository
    {
        Task<CartDto> GetCartByUserId(string userId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string code);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
    }
}
