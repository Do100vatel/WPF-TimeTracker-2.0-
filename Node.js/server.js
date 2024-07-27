const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const cors = require('cors');

const app = express();
const port = 3000;

// Middleware
app.use(bodyParser.json());
app.use(cors());

// MongoDB connection
mongoose.connect('mongodb://localhost:27017/timetracker');

// Схема и модель для категорий
const categorySchema = new mongoose.Schema({
  name: String,
  subcategories: [String]
});

const Category = mongoose.model('Category', categorySchema);

// Маршруты
app.get('/api/categories', async (req, res) => {
  const categories = await Category.find();
  res.json(categories);
});

app.post('/api/categories', async (req, res) => {
  const category = new Category(req.body);
  await category.save();
  res.json(category);
});

app.delete('/api/categories/:id', async (req, res) => {
  await Category.findByIdAndDelete(req.params.id);
  res.json({ message: 'Category deleted' });
});

app.listen(port, () => {
  console.log(`Server running on port ${port}`);
});
